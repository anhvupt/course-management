import { ChangeDetectionStrategy, Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { IStudent } from 'src/app/shared/models/student';

@Component({
  selector: 'app-students-input-form',
  templateUrl: './students-input-form.component.html',
  styleUrls: ['./students-input-form.component.css'],
})
export class StudentsInputFormComponent implements OnInit {

  constructor() { }

  @Input() student: IStudent
  @Output() studentSubmitted: EventEmitter<IStudent> = new EventEmitter<IStudent>()

  ngOnInit(): void {
  }

  onSubmit(){
    this.studentSubmitted.emit(this.student)
  }
}
