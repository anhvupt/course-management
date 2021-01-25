import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentCreateOrEditComponent } from './student-create-or-edit/student-create-or-edit.component';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    StudentCreateOrEditComponent
  ],
  imports: [
    CommonModule,
    FormsModule
  ],
  exports:[
    StudentCreateOrEditComponent,
    FormsModule
  ]
})
export class SharedModule { }
