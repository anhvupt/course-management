import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { StudentsService } from 'src/app/feature-components/students/students.service';
import { IStudent } from '../student-shared';

@Component({
  selector: 'app-student-create',
  templateUrl: './student-create.component.html',
  styleUrls: ['./student-create.component.css']
})
export class StudentCreateComponent implements OnInit {

  constructor(private studentService : StudentsService, public router: Router) { }

  student : IStudent

  ngOnInit(): void {
    this.student = {
      firstMidName: '',
      lastName : '',
      enrollmentDate : new Date()
    }
  }

  onStudentSubmitted(data: IStudent){
    this.studentService.createStudent(data)
    this.router.navigate(['/students'])
  }

}
