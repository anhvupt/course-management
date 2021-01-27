import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PaginationComponent } from './pagination/pagination.component';
import { BackButtonComponent } from './back-button/back-button.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [PaginationComponent, BackButtonComponent],
  imports: [
    CommonModule,
    RouterModule
  ],
  exports: [
    CommonModule, 
    PaginationComponent, 
    BackButtonComponent
  ]
})
export class SharedModule { }
