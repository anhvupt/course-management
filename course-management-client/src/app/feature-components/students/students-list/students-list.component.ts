import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import { StudentsService, StudentDisplayState } from 'src/app/feature-components/students/students.service';
import { IStudentDisplay, StudentParams } from '../student-shared';
import { PaginationComponent } from '../../../shared/pagination/pagination.component';
import { NgIf, NgFor, AsyncPipe } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';

@Component({
    selector: 'app-students-list',
    templateUrl: './students-list.component.html',
    styleUrls: ['./students-list.component.css'],
    changeDetection: ChangeDetectionStrategy.OnPush,
    standalone: true,
    imports: [RouterLink, FormsModule, NgIf, NgFor, PaginationComponent, AsyncPipe]
})
export class StudentsListComponent {

  params = new StudentParams()
  vm$ : Observable<StudentDisplayState> = this.studentService.vm$
  totalPage$ : Observable<number> = this.studentService.totalPage$

  constructor(private studentService: StudentsService) { }


  onPageChange(pageIndex: number){
    this.studentService.updatePagination(pageIndex)
  }

  onSearch(event:any){
    this.studentService.updateSearch(event.target.value)
  }

}
