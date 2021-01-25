import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { RouterModule } from '@angular/router';
import { StudentsModule } from './students/students.module';
import { StudentService } from '../services/student.service';
import { HttpClientModule } from '@angular/common/http';
import { InstructorsModule } from './instructors/instructors.module';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    StudentsModule,
    InstructorsModule,
    RouterModule.forRoot([
      {path: '', redirectTo: 'students', pathMatch: 'full'},
      {path: '**', redirectTo: 'students', pathMatch: 'full'}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
