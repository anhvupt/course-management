import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { StudentsService, StudentDisplayState } from 'src/app/feature-components/students/students.service';
import { IStudent } from '../student-shared';

@Component({
  selector: 'app-students-detail',
  templateUrl: './students-detail.component.html',
  styleUrls: ['./students-detail.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class StudentsDetailComponent {

  vm$ : Observable<StudentDisplayState> = this.studentService.vm$

  constructor(private studentService: StudentsService) { }

  onRemoveStudent(id: number): void {
    // if (confirm("Are you sure you want to remove this student!")) {
    //   this.studentService.removeStudent(id).subscribe({
    //     next: () => {
    //       history.back()
    //     },
    //     error: err => console.error(err)
    //   })
    // }
  }

}
