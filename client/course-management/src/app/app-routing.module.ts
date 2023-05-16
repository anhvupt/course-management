import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { LoginComponent } from './core/login/login.component';



@NgModule({
  declarations: [],
  imports: [
    RouterModule.forRoot([
    { path: 'login', component: LoginComponent },
    { path: '', redirectTo: 'students', pathMatch: 'full' },
    { path: '**', redirectTo: 'students', pathMatch: 'full' }
    ])
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule {}
