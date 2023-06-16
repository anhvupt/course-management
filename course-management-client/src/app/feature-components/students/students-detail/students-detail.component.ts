import { Location, NgIf, AsyncPipe } from '@angular/common';
import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { Observable } from 'rxjs';
import { StudentsService, StudentDisplayState } from 'src/app/feature-components/students/students.service';
import { IStudent } from '../student-shared';
import { BackButtonComponent } from '../../../shared/back-button/back-button.component';

@Component({
    selector: 'app-students-detail',
    templateUrl: './students-detail.component.html',
    styleUrls: ['./students-detail.component.css'],
    changeDetection: ChangeDetectionStrategy.OnPush,
    standalone: true,
    imports: [NgIf, BackButtonComponent, RouterLink, AsyncPipe]
})
export class StudentsDetailComponent {

  vm$ : Observable<StudentDisplayState> = this.studentService.vm$

  constructor(private studentService: StudentsService, 
    private router : Router) { }

  onRemoveStudent(id: number): void {
    this.studentService.deleteStudent(id)
    this.router.navigate(['/students'])
  }

}
