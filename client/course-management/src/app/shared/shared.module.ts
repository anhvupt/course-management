import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PaginationComponent } from './pagination/pagination.component';



@NgModule({
  declarations: [PaginationComponent],
  imports: [
    CommonModule
  ],
  exports: [
    CommonModule, 
    PaginationComponent
  ]
})
export class SharedModule { }
