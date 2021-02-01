import { Location } from '@angular/common';
import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { map } from 'rxjs/operators';
import { StudentsService } from 'src/app/feature-components/students/students.service';
import { StudentHttpService } from '../student-http.service';
import { IStudent, IStudentDisplay } from '../student-shared';

@Component({
  selector: 'app-students-edit',
  templateUrl: './students-edit.component.html',
  styleUrls: ['./students-edit.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class StudentsEditComponent{

  student: IStudent 

  constructor(private studentService: StudentsService, private location: Location) {
    this.studentService.student$.pipe(
      map(student => ({
        firstMidName: student.firstMidName,
        lastName: student.lastName,
        enrollmentDate: student.enrollmentDate
      }))
    ).subscribe(student => this.student = student)
  }

  onStudentSubmitted(data: IStudent) {
    this.studentService.editStudent(data)
    this.location.back()
  }

}
