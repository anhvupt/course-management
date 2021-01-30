import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpParams } from '@angular/common/http';
import { BehaviorSubject, combineLatest, EMPTY, Observable, of, Subject, throwError } from 'rxjs';
import { tap, map, catchError, distinctUntilChanged, distinctUntilKeyChanged, last, switchMap, concatMap } from 'rxjs/operators'
import { ApiUrl } from '../../shared/models/api-url';
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

  onParamsChange = this.params$.pipe(
    tap(params => console.log('params is changed: ', params)),
    switchMap(params => this.studentHttp.getStudents(toHttpParams(params)))
  ).subscribe(students => {
    this.updateState({ ..._state, students })
  })
    

  onStudentIdChange = this.studentId$.pipe(
    tap(id => console.log('student id is changed: ', id)),
    switchMap(id => (id > 0) ? this.studentHttp.getStudent(id) : EMPTY)
  ).subscribe(student => {
    this.updateState({ ..._state, student })
  })
    

  onStudentCreate = this.studentCreate$.pipe(
    tap(student => console.log('student to create: ', student)),
    switchMap(student => this.studentHttp.createStudent(student))
  ).subscribe({ error: err => handleError(err) })
    

  onStudentEdit = this.studentEdit$.pipe(
    tap(student => console.log('student to edit: ', student),
      switchMap(student => this.studentHttp.editStudent(
        _state.studentId, student as IStudent)
      ))
  ).subscribe({ error: err => handleError(err) })
    

  onStudentDelete = this.idToDelete$.pipe(
    tap(id => console.log('id to delete: ', id)),
    switchMap(id => this.studentHttp.removeStudent(id))
  ).subscribe({
    next: () => this.updateState({..._state, studentId: 0, student: null
    }),
    error: err => handleError(err)
  })
    
  onStudentManipulation =
    combineLatest([this.studentCreate$, this.studentEdit$, this.idToDelete$]).pipe(
      switchMap(() => this.studentHttp.getStudents(toHttpParams(_state.params)))
    ).subscribe(students => this.updateState({ ..._state, students }))


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
    if (studentId != _state.studentId) {
      this.updateState({ ..._state, studentId })
    }
  }
  createStudent(student: IStudent) {
    this.studentCreateSubject.next(student)
  }

  private updateState(state: StudentDisplayState) {
    this.store.next(_state = state)
  }
}
