import { Injectable } from '@angular/core';
import { BehaviorSubject, combineLatest, EMPTY, Observable, Subject } from 'rxjs';
import { tap, map, distinctUntilChanged, switchMap } from 'rxjs/operators'
import { handleError, IStudent, IStudentDisplay, StudentDisplay, StudentParams, toHttpParams } from './student-shared';
import { StudentHttpService } from './student-http.service';


export class StudentDisplayState {
  students: IStudentDisplay[]
  params: StudentParams
  student: IStudentDisplay
  studentId: number
}


let _state: StudentDisplayState = {
  students: [],
  params: new StudentParams(),
  student: new StudentDisplay(),
  studentId: new StudentDisplay().id,
}


@Injectable({
  providedIn: 'root'
})
export class StudentsService {

  private store = new BehaviorSubject<StudentDisplayState>(_state)
  private state$ = this.store.asObservable()

  students$: Observable<IStudentDisplay[]> =
    this.state$.pipe(map(state => state.students), distinctUntilChanged())
  params$: Observable<StudentParams> =
    this.state$.pipe(map(state => state.params), distinctUntilChanged())
  student$: Observable<IStudentDisplay> =
    this.state$.pipe(map(state => state.student), distinctUntilChanged())
  studentId$: Observable<number> =
    this.state$.pipe(map(state => state.studentId), distinctUntilChanged())
  
  vm$: Observable<StudentDisplayState> =
    combineLatest([this.students$, this.params$, this.student$, this.studentId$])
      .pipe(
        map(([students, params, student, studentId]) =>
          ({ students, params, student, studentId }))
      )

  private studentCreateSubject = new Subject<IStudent>()
  studentCreate$: Observable<IStudent> = this.studentCreateSubject.asObservable()
  private studentEditSubject = new Subject<IStudent>()
  studentEdit$: Observable<IStudent> = this.studentEditSubject.asObservable()
  private studentDeleteSubject = new Subject<number>()
  idToDelete$: Observable<number> = this.studentDeleteSubject.asObservable() 
  private totalPageSubject = new BehaviorSubject(3)
  totalPage$ = this.totalPageSubject.asObservable()

  private onParamsChange = this.params$.pipe(
    tap(params => console.log('params is changed: ', params)),
    switchMap(params => {
      this.studentHttp.getTotalPage(params.pageSize).subscribe( 
        total => this.totalPageSubject.next(total)
      )
      return this.studentHttp.getStudents(toHttpParams(params))
    })
  ).subscribe(students => {
    this.updateState({ ..._state, students })
  })
    
  private onStudentIdChange = this.studentId$.pipe(
    tap(id => console.log('student id is changed: ', id)),
    switchMap(id => (id > 0) ? this.studentHttp.getStudent(id) : EMPTY)
  ).subscribe(student => {
    this.updateState({ ..._state, student })
  })
    
  private onStudentCreate = this.studentCreate$.pipe(
    tap(student => console.log(`student to create: `, student)),
    switchMap(student => this.studentHttp.createStudent(student))
  ).subscribe({ 
    next: () => {this.refetchStudents()},
    error: err => handleError(err) }
  )
    
  private onStudentEdit = this.studentEdit$.pipe(
    tap(student => {
      console.log('student to create: ', student, typeof(student))
      console.log('id: ', _state.studentId)
    }),
    switchMap(student => {
      console.log(student)
      console.log(_state.studentId)
      return this.studentHttp.editStudent(_state.studentId, student)
    })
  )
    
  private onStudentDelete = this.idToDelete$.pipe(
    tap(id => console.log('id to delete: ', id)),
    switchMap(id => this.studentHttp.removeStudent(id))
  ).subscribe({
    next: () => {
      this.updateState({..._state, studentId: 0, student: null})
      this.refetchStudents()
    },
    error: err => handleError(err)
  })
  

  constructor(private studentHttp: StudentHttpService) { }

  updateSearch(searchQuery: string) {
    if (searchQuery != _state.params.searchQuery) {
      const params = { ..._state.params, searchQuery }
      this.updateState({ ..._state, params })
    }
  }
  updatePagination(pageIndex: number) {
    if (pageIndex != _state.params.pageIndex) {
      const params = { ..._state.params, pageIndex }
      this.updateState({ ..._state, params })
    }
  }
  updateStudentId(studentId: number) {
    this.updateState({ ..._state, studentId })
  }
  createStudent(student: IStudent) {
    this.studentCreateSubject.next(student)
  }
  editStudent(student: IStudent){
    this.studentEditSubject.next(student)
  }
  deleteStudent(id: number){
    this.studentDeleteSubject.next(id)
  }

  private refetchStudents(){
    this.studentHttp.getStudents(toHttpParams(_state.params)).subscribe(
      students => this.updateState({... _state, students})
    )
  }
  private refetchStudent(){
    this.studentHttp.getStudent(_state.studentId).subscribe(
      student => this.updateState({..._state, student})
    )
  }
  private updateState(state: StudentDisplayState) {
    this.store.next(_state = state)
  }
}
