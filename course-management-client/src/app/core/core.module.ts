import { CommonModule } from '@angular/common';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http'
import { NgModule } from '@angular/core';
import { LoginComponent } from './login/login.component';
import { TokenInterceptor } from './token-interceptor';



@NgModule({
    imports: [
        CommonModule,
        HttpClientModule,
        LoginComponent,
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
