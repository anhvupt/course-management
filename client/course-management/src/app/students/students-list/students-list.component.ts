import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IStudentDisplay } from 'src/app/models/student-display';
import { StudentParams } from 'src/app/models/student-params';
import { StudentService } from '../../services/student.service';

@Component({
  selector: 'app-students-list',
  templateUrl: './students-list.component.html',
  styleUrls: ['./students-list.component.css']
})
export class StudentsListComponent implements OnInit {

  params : StudentParams = new StudentParams()
  students : IStudentDisplay[] = [] 
  errorMessage = ''

  constructor(private studentService: StudentService, private router: Router) { }

  ngOnInit(): void {
    this.studentService.getStudents(this.params).subscribe({
      next: students => this.students = students,
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

}
