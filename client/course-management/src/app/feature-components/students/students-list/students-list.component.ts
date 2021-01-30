import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
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
  students$ : Observable<IStudentDisplay[]> 
  vm$ : Observable<StudentDisplayState> = this.studentService.vm$

  constructor(private studentService: StudentsService) { }


  onRemoveStudent(id: number): void {
    // if (confirm("Are you sure you want to remove this student!")) {
    //   this.studentService.removeStudent(id)
    //     .subscribe({
    //       next: () => {
    //         location.reload()
    //       },
    //       error: err => console.error(err)
    //     })
    // }
  }

  onPageChange(pageIndex: number){
    this.studentService.updatePagination(pageIndex)
  }

  onSearch(event:any){
    this.studentService.updateSearch(event.target.value)
  }

}
