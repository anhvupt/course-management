import { Component, OnInit } from '@angular/core';
import { IStudent } from 'src/app/models/student';

@Component({
  selector: 'app-student-edit-or-update',
  templateUrl: './student-edit-or-update.component.html',
  styleUrls: ['./student-edit-or-update.component.css']
})
export class StudentEditOrUpdateComponent implements OnInit {

  constructor() { }

  student: IStudent

  ngOnInit(): void {
  }

}
