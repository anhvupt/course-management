import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentService } from './services/student.service';
import { HttpClientModule } from '@angular/common/http';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ],
  exports: [
    HttpClientModule,
  ]
})
export class CoreModule { }
