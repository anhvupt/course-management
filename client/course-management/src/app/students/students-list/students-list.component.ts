import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IStudentDisplay } from 'src/app/models/student-display';
import { StudentParams } from 'src/app/models/student-params';
import { StudentService } from 'src/app/services/student.service';

@Component({
  selector: 'app-students-list',
  templateUrl: './students-list.component.html',
  styleUrls: ['./students-list.component.css']
})
export class StudentsListComponent implements OnInit {

  params = new StudentParams()
  students : IStudentDisplay[] = [] 
  errorMessage = ''

  constructor(private studentService: StudentService,
              private router: Router,
              private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.route.queryParams.subscribe(params => {
      this.params.searchQuery = params.searchQuery || this.params.searchQuery
      this.params.pageIndex = params.pageIndex || this.params.pageIndex
      this.params.pageSize = params.pageSize || this.params.pageSize
      this.params.orderBy = params.orderBy || this.params.orderBy
      this.params.revert = params.revert || this.params.revert
    })
    console.log(this.params)
    this.getStudents()
  }

  getStudents(): void{
    this.studentService.getStudents(this.params).subscribe({
      next: students => {
        this.students = students
        console.log(JSON.stringify(this.students))
      },
      error: err => this.errorMessage = err 
    })
  }

  onRemoveStudent(id: number):void{
    this.studentService.removeStudent(id).subscribe( {
      next: ()=>{
        if(confirm("successfully removed!")){
          location.reload()
        }
      },
      error: err => console.error(err)
    })
  }

  onPageChange(pageIndex: string){
    this.setPageIndex(pageIndex)
    this.getStudents()
  }

  onSearch(){
    console.log(this.params)
    this.getStudents()
  }

  setPageIndex(pageIndex: string){
    switch(pageIndex){
      case 'prev': {
        this.params.pageIndex--
        break
      }
      case 'next':{
        this.params.pageIndex++
        break
      }
      default: {
        this.params.pageIndex = +pageIndex
        break;
      }
    }
  }

}
