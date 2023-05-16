import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { LocalStorageService } from "../local-storage.service";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private router : Router, 
    private local : LocalStorageService) { }

  ngOnInit(): void {
  }

  onLoggedIn(){
    const token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwidW5pcXVlX25hbWUiOiJMZW9ub3JCYXVjaCIsIm5iZiI6MTYxMjc3ODkwMSwiZXhwIjoxNjEyNzc5ODAxLCJpYXQiOjE2MTI3Nzg5MDEsImlzcyI6IkNvdXJzZU1hbmFnZW1lbnRBUEkiLCJhdWQiOiJDb3Vyc2VNYW5hZ2VtZW50QVBJIn0.Jq2N1rN5yccLIGqfzPJ8Az_aXxcc7lThP7kKNghmdXweyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwidW5pcXVlX25hbWUiOiJUaGVvZG9yYVNjaGlubmVyIiwibmJmIjoxNjgzNDMxNDU3LCJleHAiOjE2ODM0MzIzNTcsImlhdCI6MTY4MzQzMTQ1NywiaXNzIjoiQ291cnNlTWFuYWdlbWVudEFQSSIsImF1ZCI6IkNvdXJzZU1hbmFnZW1lbnRBUEkifQ.iMOoJLk09RHFPy5mJPzzShrMQWhJ6Kl1zf6gvfzWZBU"
    this.local.setToken(token)
    this.router.navigate(['/'])
  }

}
