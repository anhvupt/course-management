import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpParams } from '@angular/common/http';
import { BehaviorSubject, combineLatest, Observable, throwError } from 'rxjs';
import { tap, map, catchError, distinctUntilChanged, distinctUntilKeyChanged, last, switchMap } from 'rxjs/operators'
import { ApiUrl } from '../../shared/models/api-url';
import { IStudent, IStudentDisplay, StudentParams, StudentState, toHttpParams } from './student';
import { state } from '@angular/animations';


let _state: StudentState = {
  students: [],
  params: new StudentParams(),
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
  loading$ = this.state$.pipe(map(state => state.loading))
  vm$: Observable<StudentState> =
    combineLatest([this.students$, this.params$, this.loading$])
      .pipe(
        map(([students, params, loading]) => ({ students, params, loading }))
      )

  constructor(private http: HttpClient) {
    combineLatest([this.params$]).pipe(
      switchMap(([params]) => this.getStudents(toHttpParams(params)))
    ).subscribe(students => {
      this.updateState({ ..._state, students, loading: false })
    })
  }

  updateSearch(searchQuery: string) {
    const params = { ..._state.params, searchQuery }
    this.updateState({ ..._state, params })
  }
  updatePagination(pageIndex: number) {
    const params = { ..._state.params, pageIndex }
    this.updateState({ ..._state, params })
  }


  updateState(state: StudentState) {
    this.store.next(_state = state)
  }

  private getStudents(params: HttpParams): Observable<IStudentDisplay[]> {
    return this.http.get<IStudentDisplay[]>(ApiUrl.student, { params: params })
      .pipe(
        catchError(this.handleError)
      )
  }
  private refetch(){
    this.getStudents(toHttpParams(_state.params))
    .subscribe(students => {
      this.updateState({ ..._state, students, loading: false })
    })
  }

  getStudent(id: number): Observable<IStudentDisplay> {
    let url = `${ApiUrl.student}/${id}`
    return this.http.get<IStudentDisplay>(url)
      .pipe(
        catchError(this.handleError)
      )
  }

  createStudent(student: IStudent) {
    return this.http.post(ApiUrl.student, student)
      .pipe(
        tap(() => this.refetch()),
        catchError(this.handleError)
      )
  }

  editStudent(id: number, student: IStudent) {
    let url = `${ApiUrl.student}/${id}`
    return this.http.put(url, student)
      .pipe(
        tap(() => this.refetch()),
        catchError(this.handleError)
      )
  }

  removeStudent(id: number) {
    let url = `${ApiUrl.student}/${id}`
    return this.http.delete(url)
      .pipe(
        tap(() => this.refetch()),
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
