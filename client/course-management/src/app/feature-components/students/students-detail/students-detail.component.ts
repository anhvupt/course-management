import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { StudentService } from 'src/app/feature-components/students/student.service';
import { IStudent } from '../student';

@Component({
  selector: 'app-students-detail',
  templateUrl: './students-detail.component.html',
  styleUrls: ['./students-detail.component.css']
})
export class StudentsDetailComponent implements OnInit {

  constructor(private route: ActivatedRoute,
              private studentService: StudentService, 
              private router: Router) { }


  student: IStudent = {
    firstMidName : '',
    lastName: '',
    enrollmentDate : new Date(),
  }
  studentId: number

  ngOnInit(): void {
    this.route.data.subscribe(data => {
      let resolvedData = data['resolvedData']
      if (resolvedData.student) {
        this.student = resolvedData.student
        this.studentId = resolvedData.id
      }else{
        console.error(resolvedData.error)
      }
    })
  }

  onRemoveStudent(id: number): void {
    if (confirm("Are you sure you want to remove this student!")) {
      this.studentService.removeStudent(id).subscribe({
        next: () => {
          history.back()
        },
        error: err => console.error(err)
      })
    }
  }

}
