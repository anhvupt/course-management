import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { StudentsRoutingModule } from './students-routing.module';
import { MatTableModule } from '@angular/material/table';
import { SharedModule } from '../../shared/shared.module';

@NgModule({
  declarations: [StudentsRoutingModule.components],
  imports: [SharedModule, FormsModule, StudentsRoutingModule, MatTableModule]
})
export class StudentsModule {}
