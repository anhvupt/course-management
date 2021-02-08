import { Injectable } from "@angular/core"

export const LocalStorageKeys = {
  token : 'TOKEN'
} 

@Injectable({
  providedIn: 'root'
})
export class LocalStorageService {

  constructor() { }

  setToken(value: string){
    localStorage.setItem(LocalStorageKeys.token, value)
  }
  getToken(): string{
    return localStorage.getItem(LocalStorageKeys.token)
  }
  removeToken() {
    localStorage.removeItem(LocalStorageKeys.token)
  }
  clear(){
    localStorage.clear()
  }
}
