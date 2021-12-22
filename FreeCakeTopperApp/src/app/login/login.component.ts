import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor() { }

  public user = {
    email: "fred@teste.com",
    password: "123"
  }
  ngOnInit(): void {
  }

  verifyPassword() {
    if (this.user.email != "fred@teste.com" && this.user.password != "123") {
      console.log("errou");
    }
  }

}
