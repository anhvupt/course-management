import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { StudentsModule } from './feature-components/students/students.module';
import { InstructorsModule } from './feature-components/instructors/instructors.module';
import { CoreModule } from './core/core.module';
import { AppRoutingModule } from './app-routing.module';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { TokenInterceptor as TokenInterceptor } from './core/token-interceptor';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    CoreModule,
    InstructorsModule,
    AppRoutingModule,
    NgbModule,
    BrowserAnimationsModule,
    StudentsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
