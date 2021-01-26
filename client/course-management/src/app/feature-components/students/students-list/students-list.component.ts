import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { StudentService } from 'src/app/core/services/student.service';
import { IStudentDisplay, StudentParams } from 'src/app/shared/models/student';

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
              private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.route.queryParams.subscribe(params => {
      this.params = JSON.parse(JSON.stringify(params))
    })
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

  // onPageChange(pageIndex: string){
  //   this.setPageIndex(pageIndex)
  //   this.getStudents()
  // }

  onPageChange(pageIndex: number){
    this.params.pageIndex = pageIndex
    console.log('params after clicked: ',this.params)
    this.getStudents()
  }

  onSearch(){
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
