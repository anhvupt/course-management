import { AsyncPipe, NgFor, NgIf } from '@angular/common';
import { ChangeDetectionStrategy, Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { Observable } from 'rxjs';
import { StudentDisplayState, StudentsService } from 'src/app/feature-components/students/students.service';
import { PaginationComponent } from '../../../shared/pagination/pagination.component';
import { StudentParams } from '../student-shared';

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
