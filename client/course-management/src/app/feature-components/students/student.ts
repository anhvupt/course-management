import { HttpParams } from "@angular/common/http";

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
export const toHttpParams = (params : StudentParams): HttpParams => {
    let result = new HttpParams()
    if (params.searchQuery) { result = result.set('searchQuery', params.searchQuery) }
    if (params.pageSize) { result = result.set('pageSize', `${params.pageSize}`) }
    if (params.pageIndex) { result = result.set('pageIndex', `${params.pageIndex}`) }
    if (params.orderBy) { result = result.set('orderBy', params.orderBy) }
    if (params.revert) { result = result.set('revert', `${params.revert}`) }
    return result
}

export interface IStudentDisplay{
    id: number,
    firstMidName: string,
    lastName: string,
    name: string,
    enrollmentDuration: string,
    enrollmentDate: Date,
}

export class StudentResolved{
    id?: number
    student: IStudent
    error?: any
}

export class StudentState{
    students: IStudentDisplay[]
    params: StudentParams
    loading: boolean
}