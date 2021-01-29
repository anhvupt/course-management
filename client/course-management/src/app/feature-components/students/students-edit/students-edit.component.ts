import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { StudentService } from 'src/app/feature-components/students/student.service';
import { IStudent } from '../student';

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
          this.router.navigate(['/students'])
      },
      error: err => console.error(err)
    })
  }

}
