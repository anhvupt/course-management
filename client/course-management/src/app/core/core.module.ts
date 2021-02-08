import { CommonModule } from '@angular/common';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http'
import { NgModule } from '@angular/core';
import { LoginComponent } from './login/login.component';
import { TokenInterceptor } from './token-interceptor';



@NgModule({
  declarations: [LoginComponent],
  imports: [
    CommonModule,
    HttpClientModule,
  ],
  exports: [
    HttpClientModule, LoginComponent
  ],
  providers: [    
  {
    provide: HTTP_INTERCEPTORS,
    useClass: TokenInterceptor,
    multi: true
  }
]
})
export class CoreModule { }
