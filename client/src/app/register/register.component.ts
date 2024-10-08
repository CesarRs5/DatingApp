import { Component,   inject,   output } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {
  private accountService=inject (AccountService);
  //usersFromHomeComponent=input.required<any>() ;
  //@Output() cancelRegister = new EventEmitter();
  cancelRegister = output<boolean>();
  model:any ={};

  login():void{
    this.accountService.register(this.model).subscribe({
      next: (response)=> {
        console.log(response);       
        } ,
      error: (error)=>{
        console.log(error);
      }
    })
  }

  register():void{
    this.accountService.login(this.model).subscribe({
      next: (response)=> {
        console.log(response);       
        } ,
      error: (error)=>{
        console.log(error);
      }
    })
  }

  cancel (): void{
    this.cancelRegister.emit(false);
  }

}
