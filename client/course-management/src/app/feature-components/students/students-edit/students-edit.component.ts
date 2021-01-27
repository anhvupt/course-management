import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IStudent } from 'src/app/shared/models/student';
import { StudentService } from 'src/app/core/services/student.service';

@Component({
  selector: 'app-students-edit',
  templateUrl: './students-edit.component.html',
  styleUrls: ['./students-edit.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
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

    // this.studentId = +this.route.snapshot.paramMap.get('id')
    // this.studentService.getStudent(this.studentId).subscribe({
    //   next: data => {
    //     console.log(data)
    //     this.student.firstMidName = data.firstMidName
    //     this.student.lastName = data.lastName
    //   },
    //   error: err => console.error(err)
    // })

    this.route.data.subscribe(data =>{
      let resolvedData = data['resolvedData']
      if (resolvedData.student) {
        this.student = resolvedData.student
        this.studentId = resolvedData.id
      }else{
        console.error(resolvedData.error)
      }
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
