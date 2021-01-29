import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpParams } from '@angular/common/http';
import { BehaviorSubject, combineLatest, EMPTY, Observable, of, Subject, throwError } from 'rxjs';
import { tap, map, catchError, distinctUntilChanged, distinctUntilKeyChanged, last, switchMap, concatMap } from 'rxjs/operators'
import { ApiUrl } from '../../shared/models/api-url';
import { IStudent, IStudentDisplay, StudentDisplay, StudentParams, StudentState, toHttpParams } from './student';
import { state } from '@angular/animations';


let _state: StudentState = {
  students: [],
  params: new StudentParams(),
  student: new StudentDisplay(),
  studentId: new StudentDisplay().id,
  loading: false
}

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  private store = new BehaviorSubject<StudentState>(_state)
  private state$ = this.store.asObservable()

  students$ = this.state$.pipe(map(state => state.students),
    distinctUntilChanged())
  params$ = this.state$.pipe(map(state => state.params),
    distinctUntilChanged())
  student$ = this.state$.pipe(map(state => state.student),
    distinctUntilChanged())
  studentId$ = this.state$.pipe(map(state => state.studentId),
    distinctUntilChanged())
  loading$ = this.state$.pipe(map(state => state.loading))

  vm$: Observable<StudentState> =
    combineLatest([this.students$, this.params$, this.student$, this.studentId$, this.loading$])
      .pipe(
        map(([students, params, student, studentId, loading]) => 
        ({ students, params, student, studentId, loading }))
      )

  constructor(private http: HttpClient) {
    this.params$.pipe(
      tap(params => console.log('params is changed: ',params)),
      switchMap(params => this.getStudents(toHttpParams(params)))
    ).subscribe(students => {
      this.updateState({ ..._state, students, loading: false })
    })

    this.studentId$.pipe(
      tap(id => console.log('student id is changed', id )),
      switchMap(id => (id >0) ? this.getStudent(id) : EMPTY)
    ).subscribe(student => {
      this.updateState({... _state, student, loading: false})
    })


  }

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
  updateStudentId(studentId: number){
    if (studentId != _state.studentId) {
      this.updateState({ ..._state, studentId })
    }
  }
  updateState(state: StudentState) {
    this.store.next(_state = state)
  }

  private getStudents(params: HttpParams): Observable<IStudentDisplay[]> {
    return this.http.get<IStudentDisplay[]>(ApiUrl.student, { params: params })
      .pipe(
        tap(students => console.log('successfully get students: ',students)),
        catchError(this.handleError)
      )
  }

  private getStudent(id: number): Observable<IStudentDisplay> {
    let url = `${ApiUrl.student}/${id}`
    return this.http.get<IStudentDisplay>(url)
      .pipe(
        tap(student => console.log('successfully get student: ',student)),
        catchError(this.handleError)
      )
  }

  createStudent(student: IStudent) {
    return this.http.post(ApiUrl.student, student)
      .pipe(
        tap(() => console.log("student created")),
        catchError(this.handleError)
      )
  }

  editStudent(id: number, student: IStudent) {
    let url = `${ApiUrl.student}/${id}`
    return this.http.put(url, student)
      .pipe(
        catchError(this.handleError)
      )
  }

  removeStudent(id: number) {
    let url = `${ApiUrl.student}/${id}`
    return this.http.delete(url)
      .pipe(
        catchError(this.handleError)
      )
  }

  handleError(err: HttpErrorResponse): Observable<never> {
    let errorMessage = '';
    if (err.error instanceof ErrorEvent) {
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {
      errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
    }
    console.error(errorMessage);
    return throwError(errorMessage);
  }
}
