import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { StudentService } from 'src/app/feature-components/students/student.service';
import { IStudent } from '../student';

@Component({
  selector: 'app-student-create',
  templateUrl: './student-create.component.html',
  styleUrls: ['./student-create.component.css']
})
export class StudentCreateComponent implements OnInit {

  constructor(private studentService : StudentService, public router: Router) { }

  student : IStudent

  ngOnInit(): void {
    this.student = {
      firstMidName: '',
      lastName : '',
      enrollmentDate : new Date()
    }
  }

  onStudentSubmitted(data: IStudent){
    this.student = data
    console.log('student to submit: ', this.student)
    this.studentService.createStudent(this.student).subscribe({
      next: () => {
          this.router.navigate(['/students'])
      },
      error: err => console.error(err) 
    })
  }

}
