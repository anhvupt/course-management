import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import { StudentsService, StudentDisplayState } from 'src/app/feature-components/students/students.service';
import { IStudentDisplay, StudentParams } from '../student-shared';

@Component({
  selector: 'app-students-list',
  templateUrl: './students-list.component.html',
  styleUrls: ['./students-list.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class StudentsListComponent {

  params = new StudentParams()
  //students$ : Observable<IStudentDisplay[]> 
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
