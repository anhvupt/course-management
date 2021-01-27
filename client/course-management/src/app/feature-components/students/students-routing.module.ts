import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { StudentCreateComponent } from './student-create/student-create.component';
import { StudentsDetailComponent } from './students-detail/students-detail.component';
import { StudentsEditComponent } from './students-edit/students-edit.component';
import { StudentsInputFormComponent } from './students-input-form/students-input-form.component';
import { StudentsListComponent } from './students-list/students-list.component';



@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild([
      {path: 'students', component: StudentsListComponent},
      {path: 'students/create', component: StudentCreateComponent},
      {path: 'students/:id', component: StudentsDetailComponent},
      {path: 'students/:id/edit', component: StudentsEditComponent},
    ])
  ],
  exports: [
    RouterModule
  ]
})
export class StudentsRoutingModule { 
  static components = [
    StudentsInputFormComponent,
    StudentsListComponent,
    StudentCreateComponent,
    StudentsEditComponent,
    StudentsDetailComponent,
  ]
}
