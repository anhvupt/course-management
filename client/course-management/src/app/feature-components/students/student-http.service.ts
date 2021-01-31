import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { EMPTY, Observable } from 'rxjs';
import { catchError, tap } from 'rxjs/operators';
import { ApiUrl } from 'src/app/shared/models/api-url';
import { handleError, IStudent, IStudentDisplay } from './student-shared';

@Injectable({
  providedIn: 'root'
})
export class StudentHttpService {

  constructor(private http: HttpClient) {}

  
  getStudents(params: HttpParams): Observable<IStudentDisplay[]> {
    return this.http.get<IStudentDisplay[]>(ApiUrl.student, { params: params })
      .pipe(
        tap(students => console.log('successfully get students: ', students)),
        catchError(handleError)
      )
  }

  getStudent(id: number): Observable<IStudentDisplay> {
    let url = `${ApiUrl.student}/${id}`
    return this.http.get<IStudentDisplay>(url)
      .pipe(
        tap(student => console.log('successfully get student: ', student)),
        catchError(handleError)
      )
  }

  createStudent(student: IStudent) {
    return this.http.post(ApiUrl.student, student)
      .pipe(
        tap(() => console.log("student created")),
        catchError(handleError)
      )
  }

  editStudent(id: number, student: IStudent) {
    let url = `${ApiUrl.student}/${id}`
    return this.http.put(url, student)
      .pipe(
        tap (() => console.log("student edited")),
        catchError(handleError)
      )
  }

  removeStudent(id: number) {
    let url = `${ApiUrl.student}/${id}`
    return this.http.delete(url)
      .pipe(
        catchError(handleError)
      )
  }

}
