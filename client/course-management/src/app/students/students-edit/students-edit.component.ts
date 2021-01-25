import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IStudent } from 'src/app/models/student';
import { StudentService } from 'src/app/services/student.service';

@Component({
  selector: 'app-students-edit',
  templateUrl: './students-edit.component.html',
  styleUrls: ['./students-edit.component.css']
})
export class StudentsEditComponent implements OnInit {

  constructor(private studentService : StudentService,
              public router: Router, 
              private route: ActivatedRoute) { }

  student : IStudent

  ngOnInit(): void {
    const id = +this.route.snapshot.paramMap.get('id')
    this.studentService.getStudent(id).subscribe({
      next: data => {
        console.log(data)
      },
      error: err => console.error(err)   
    })
  }

  onStudentSubmitted(data: IStudent){
    this.student = data
    console.log('student to submit: ', this.student)
    this.studentService.createStudent(this.student).subscribe({
      next: () => {
        if(confirm('successfully created!')){
          this.router.navigate(['/students'])
        }
      },
      error: err => console.error(err) 
    })
  }

}
