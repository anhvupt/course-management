import { ChangeDetectionStrategy, Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Subject } from 'rxjs';
import { tap } from 'rxjs/operators';
import { IStudent } from '../student-shared';

@Component({
  selector: 'app-students-input-form',
  templateUrl: './students-input-form.component.html',
  styleUrls: ['./students-input-form.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class StudentsInputFormComponent implements OnInit {

  private errorSubject = new Subject<string>()
  errorMessage$ = this.errorSubject.asObservable()
  constructor() { }

  @Input() student: IStudent
  @Output() studentSubmitted: EventEmitter<IStudent> = new EventEmitter<IStudent>()

  ngOnInit(): void {
  }

  onSubmit(){
    if (this.validate(this.student)) {
      this.studentSubmitted.emit(this.student)
      this.errorSubject.next(null)
    } else {
      const err = 'Please complete the validation'
      this.errorSubject.next(err)
      this.errorMessage$.subscribe(err => console.error(err))
    }
  }

  validate(student: IStudent){
    return (student.firstMidName && student.lastName) &&
    (student.firstMidName.length < 200) &&
    (student.lastName.length < 200)
  }
}
