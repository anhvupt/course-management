import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentEditOrUpdateComponent } from './student-edit-or-update/student-edit-or-update.component';



@NgModule({
  declarations: [
    StudentEditOrUpdateComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    StudentEditOrUpdateComponent
  ]
})
export class SharedModule { }
