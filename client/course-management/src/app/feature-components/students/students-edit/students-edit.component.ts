import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { StudentsService } from 'src/app/feature-components/students/students.service';
import { IStudent } from '../student-shared';

@Component({
  selector: 'app-students-edit',
  templateUrl: './students-edit.component.html',
  styleUrls: ['./students-edit.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class StudentsEditComponent{


  vm$ = this.studentService.vm$

  constructor(private studentService: StudentsService,
    public router: Router,
    private route: ActivatedRoute) { }

  onStudentSubmitted(data: IStudent) {
    // this.student = data
    // console.log('student to submit: ', this.student)
    // this.studentService.editStudent(this.studentId, this.student).subscribe({
    //   next: () => {
    //       this.router.navigate(['/students'])
    //   },
    //   error: err => console.error(err)
    // })
  }

}
