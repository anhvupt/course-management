import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { IStudent } from 'src/app/shared/models/student';
import { StudentService } from 'src/app/core/services/student.service';

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
    const id = +this.route.snapshot.paramMap.get('id')
    this.studentId = id
    this.studentService.getStudent(id).subscribe({
      next: data => {
        console.log('student: ', data)
        this.student = data
      },
      error: err => console.error(err)
    })
  }

  onRemoveStudent(id: number):void{
    this.studentService.removeStudent(id).subscribe( {
      next: ()=>{
        if(confirm("successfully removed!")){
          history.back()
        }
      },
      error: err => console.error(err)
    })
  }

}
