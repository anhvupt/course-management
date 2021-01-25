import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { InstructorsListComponent } from './instructors-list/instructors-list.component';



@NgModule({
  declarations: [
    InstructorsListComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild([
      {path: 'instructors', component: InstructorsListComponent}
    ])
  ]
})
export class InstructorsModule { }
