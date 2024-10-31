import { Component, inject, OnInit } from '@angular/core';
import { RegisterComponent } from "../register/register.component";


@Component({
  selector: 'app-home',
  standalone: true,
  imports: [RegisterComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent  {
  registerMode =false;

  registerToggle():void{
    this.registerMode=!this.registerMode;
    console.log(this.registerMode);
  }

  cancelRegisterMode(event: boolean):void{
    this.registerMode=false;
    //console.log(this.registerMode);
  }

  
}
