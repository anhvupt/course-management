import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IStudent } from 'src/app/models/student';

@Component({
  selector: 'app-student-create-or-edit',
  templateUrl: './student-create-or-edit.component.html',
  styleUrls: ['./student-create-or-edit.component.css']
})
export class StudentCreateOrEditComponent implements OnInit {

  constructor() { }

  @Input() student: IStudent
  @Output() studentSubmitted: EventEmitter<IStudent> = new EventEmitter<IStudent>()

  ngOnInit(): void {
  }

  onSubmit(){
    this.studentSubmitted.emit(this.student)
  }

}
