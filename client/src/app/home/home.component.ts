import { Component, inject, OnInit } from '@angular/core';
import { RegisterComponent } from "../register/register.component";
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [RegisterComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit {
  registerMode =false;
  http = inject (HttpClient);
  users:any;

  ngOnInit(): void {
    this.getUsers();
  }

  registerToggle():void{
    this.registerMode=!this.registerMode;
    console.log(this.registerMode);
  }

  cancelRegisterMode(event: boolean):void{
    this.registerMode=false;
    //console.log(this.registerMode);
  }

  getUsers() {
    this.http.get("https://localhost:5001/api/users").subscribe({
      next: (response) => { this.users = response; },
      error: (error) => { console.log(error); },
      complete: () => { console.log("Request completed!"); }
    });
  }
}
