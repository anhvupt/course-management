import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpParams } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { tap, map, catchError } from 'rxjs/operators'
import { ApiUrl } from '../models/api-url';
import { StudentParams } from '../models/student-params';
import { IStudentDisplay } from '../models/student-display';
import { IStudent } from '../models/student';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private http: HttpClient) { }

  getStudents(params: StudentParams): Observable<IStudentDisplay[]> {
    let queryParams = new HttpParams()
    if (params.searchQuery) { queryParams = queryParams.append('searchQuery', params.searchQuery) }
    if (params.pageSize) { queryParams = queryParams.append('pageSize', `${params.pageSize}`) }
    if (params.pageIndex) { queryParams = queryParams.append('pageIndex', `${params.pageIndex}`) }
    if (params.orderBy) { queryParams = queryParams.append('orderBy', params.orderBy) }
    if (params.revert) { queryParams = queryParams.append('revert', `${params.revert}`) }

    return this.http.get<IStudentDisplay[]>(ApiUrl.student, { params: queryParams })
      .pipe(
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
