import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { StudentService } from 'src/app/feature-components/students/student.service';
import { IStudentDisplay, StudentParams, StudentState } from '../student';

@Component({
  selector: 'app-students-list',
  templateUrl: './students-list.component.html',
  styleUrls: ['./students-list.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class StudentsListComponent {

  params = new StudentParams()
  students$ : Observable<IStudentDisplay[]> 
  vm$ : Observable<StudentState> = this.studentService.vm$

  constructor(private studentService: StudentService) { }


  onRemoveStudent(id: number): void {
    if (confirm("Are you sure you want to remove this student!")) {
      this.studentService.removeStudent(id)
        .subscribe({
          next: () => {
            location.reload()
          },
          error: err => console.error(err)
        })
    }
  }

  onPageChange(pageIndex: number){
    this.studentService.updatePagination(pageIndex)
  }

  onSearch(event:any){
    console.log(event.target.value)
    this.studentService.updateSearch(event.target.value)
  }

}
