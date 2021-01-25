import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { RouterModule } from '@angular/router';
import { StudentsModule } from './students/students.module';
import { StudentService } from './services/student.service';
import { HttpClientModule } from '@angular/common/http';
import { StudentEditOrUpdateComponent } from './shared/student-edit-or-update/student-edit-or-update.component';
import { StudentComponent } from './shared/student/student.component';

@NgModule({
  declarations: [
    AppComponent,
    StudentEditOrUpdateComponent,
    StudentComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    StudentsModule,
    RouterModule.forRoot([
      {path: '', redirectTo: 'students', pathMatch: 'full'},
      {path: '**', redirectTo: 'students', pathMatch: 'full'}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
