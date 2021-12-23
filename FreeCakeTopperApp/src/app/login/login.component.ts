import { FormBuilder, FormGroup } from '@angular/forms';
import { Component, OnInit } from '@angular/core';

interface user {
    email: string,
    password: string
}

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private formBuilder: FormBuilder) { }
  formulario: FormGroup;


  users: user[] = [
    {email: 'fred@teste.com',password: "123"},
    {email: 'fred@gmail.com',password: "1234"},
    {email: 'fred@hotmail.com',password: "321"},
  ];
  
  ngOnInit(): void {
    this.formulario = this.formBuilder.group({
      email:[null],
      password:[null],
      })
  };


  }