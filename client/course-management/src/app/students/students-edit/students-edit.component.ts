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

  constructor(private studentService: StudentService,
    public router: Router,
    private route: ActivatedRoute) { }

  student: IStudent = {
    firstMidName: '',
    lastName: '',
    enrollmentDate: new Date(),
  }
  studentId: number

  ngOnInit(): void {

    this.studentId = +this.route.snapshot.paramMap.get('id')
    this.studentService.getStudent(this.studentId).subscribe({
      next: data => {
        console.log(data)
        this.student.firstMidName = data.firstMidName
        this.student.lastName = data.lastName
      },
      error: err => console.error(err)
    })
  }

  onStudentSubmitted(data: IStudent) {
    this.student = data
    console.log('student to submit: ', this.student)
    this.studentService.editStudent(this.studentId, this.student).subscribe({
      next: () => {
        if (confirm('successfully editted!')) {
          this.router.navigate(['/students'])
        }
      },
      error: err => console.error(err)
    })
  }

}
