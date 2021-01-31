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
export class StudentsEditComponent implements OnInit {


  vm$ = this.studentService.vm$
  student: IStudent = {
    firstMidName : '',
    lastName : '',
    enrollmentDate: null
  }

  constructor(private studentService: StudentsService,
    private location: Location) {
    this.vm$.pipe(
      map(state => state.student)
    ).subscribe(student => {
      this.student.firstMidName = student.firstMidName,
      this.student.lastName = student.lastName,
      this.student.enrollmentDate = student.enrollmentDate
    }
    )
  }

  onStudentSubmitted(data: IStudentDisplay) {
    this.studentService.editStudent(data)
    this.location.back()
  }

}
