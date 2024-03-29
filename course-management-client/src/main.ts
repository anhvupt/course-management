/// <reference types="@angular/localize" />

import { enableProdMode, importProvidersFrom } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';


import { environment } from './environments/environment';
import { AppComponent } from './app/app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppRoutingModule } from './app/app-routing.module';
import { InstructorsModule } from './app/feature-components/instructors/instructors.module';
import { StudentsModule } from './app/feature-components/students/students.module';
import { CoreModule } from './app/core/core.module';
import { BrowserModule, bootstrapApplication } from '@angular/platform-browser';

if (environment.production) {
  enableProdMode();
}

bootstrapApplication(AppComponent, {
    providers: [importProvidersFrom(BrowserModule, CoreModule, StudentsModule, InstructorsModule, AppRoutingModule, NgbModule)]
})
  .catch(err => console.error(err));
