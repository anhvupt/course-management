import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpParams } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { tap, map, catchError } from 'rxjs/operators'
import { IStudentDisplay } from '../models/student-display';
import { StudentParams } from '../models/student-params';
import { ApiUrl } from '../models/api-url';
import { IStudent } from '../models/student';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private http: HttpClient) { }

  getStudents(params: StudentParams): Observable<IStudentDisplay[]> {
    let queryParams = new HttpParams()
    if (params.searchQuery) { queryParams.set('searchQuery', params.searchQuery) }
    if (params.searchQuery) { queryParams.set('pageSize', `${params.pageSize}`) }
    if (params.searchQuery) { queryParams.set('pageIndex', `${params.pageIndex}`) }
    if (params.searchQuery) { queryParams.set('orderBy', params.orderBy) }
    if (params.searchQuery) { queryParams.set('revert', `${params.revert}`) }

    return this.http.get<IStudentDisplay[]>(ApiUrl.student, { params: queryParams })
      .pipe(
        //tap(data => console.log('Student list: ' + JSON.stringify(data))),
        catchError(this.handleError)
      )
  }

  getStudent(id: number) : Observable<IStudentDisplay>{
    let url = `${ApiUrl.student}/${id}`
    return this.http.get<IStudentDisplay>(url)
    .pipe(
      catchError(this.handleError)
    )
  }

  createStudent(student:IStudent){
    return this.http.post(ApiUrl.student, student)
    .pipe(
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

  removeStudent(id:number){
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
