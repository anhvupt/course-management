import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { StudentsRoutingModule } from './students-routing.module';
import { SharedModule } from '../../shared/shared.module';

@NgModule({
  declarations: [StudentsRoutingModule.components],
  imports: [
    SharedModule,
    FormsModule,
    StudentsRoutingModule
  ] 
})
export class StudentsModule { }
