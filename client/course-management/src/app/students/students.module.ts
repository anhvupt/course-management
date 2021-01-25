import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentsListComponent } from './students-list/students-list.component';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { StudentCreateComponent } from './student-create/student-create.component';
import { StudentsEditComponent } from './students-edit/students-edit.component';
import { StudentsDetailComponent } from './students-detail/students-detail.component';



@NgModule({
  declarations: [
    StudentsListComponent,
    StudentCreateComponent,
    StudentsEditComponent,
    StudentsDetailComponent,
  ],
  imports: [
    CommonModule,
    FormsModule,
    RouterModule.forChild([
      {path: 'students', component: StudentsListComponent},
      {path: 'students/create', component: StudentCreateComponent},
      {path: 'students/:id', component: StudentsDetailComponent},
      {path: 'students/:id/edit', component: StudentsEditComponent},
    ]),
    SharedModule
  ] 
})
export class StudentsModule { }
