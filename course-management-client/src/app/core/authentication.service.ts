import { Injectable } from '@angular/core';
//import { JwtHelperService } from '@auth0/angular-jwt';
import { LocalStorageService } from './local-storage.service';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  public constructor(private local : LocalStorageService){}
  public getToken() : string {
    return this.local.getToken()
  }
  // public isAuthenticated() : boolean{
  //   const token = this.getToken()
  //   return !this.jwtHelper.isTokenExpired(token)
  // }
}
