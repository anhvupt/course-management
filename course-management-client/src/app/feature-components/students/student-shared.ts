import { HttpErrorResponse, HttpParams } from "@angular/common/http";
import { Observable, throwError } from "rxjs";

export interface IStudent{
    firstMidName: string;
    lastName: string;
    enrollmentDate: Date;    
}
export class StudentParams{
    searchQuery: string;
    pageSize: number;
    pageIndex: number;
    orderBy: string;
    revert: boolean;
    /**
     *
     */
    constructor() {
        this.searchQuery = ''
        this.pageSize = 10,
        this.pageIndex = 1
        this.orderBy = ''
        this.revert = false
    }
}
export interface IStudentDisplay{
    id: number,
    firstMidName: string,
    lastName: string,
    name: string,
    enrollmentDuration: string,
    enrollmentDate: Date,
}
export class StudentDisplay implements IStudentDisplay{
    id: number;
    firstMidName: string;
    lastName: string;
    name: string;
    enrollmentDuration: string;
    enrollmentDate: Date;

    constructor(){
        this.id = 0
        this.firstMidName = ''
        this.lastName = ''
        this.name = ''
        this.enrollmentDuration = new Date().toString()
        this.enrollmentDate = new Date()
    }
}
export class StudentResolved{
    id?: number
    student: IStudent
    error?: any
}

export const toHttpParams = (params : StudentParams): HttpParams => {
    let result = new HttpParams()
    if (params.searchQuery) { result = result.set('searchQuery', params.searchQuery) }
    if (params.pageSize) { result = result.set('pageSize', `${params.pageSize}`) }
    if (params.pageIndex) { result = result.set('pageIndex', `${params.pageIndex}`) }
    if (params.orderBy) { result = result.set('orderBy', params.orderBy) }
    if (params.revert) { result = result.set('revert', `${params.revert}`) }
    return result
}
export const handleError = (err: HttpErrorResponse): Observable<never> => {
    let errorMessage = '';
    if (err.error instanceof ErrorEvent) {
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {
      errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
    }
    console.error(errorMessage);
    return throwError(errorMessage);
  }