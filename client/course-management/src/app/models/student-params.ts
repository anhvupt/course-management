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