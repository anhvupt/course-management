import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';



@NgModule({
  declarations: [],
  imports: [
    RouterModule.forRoot([
      {path: '', redirectTo: 'students', pathMatch: 'full'},
      {path: '**', redirectTo: 'students', pathMatch: 'full'}
    ])
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule {}
