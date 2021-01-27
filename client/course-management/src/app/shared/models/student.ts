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

export class StudentResolved{
    id?: number
    student: IStudent
    error?: any
}