import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from '../components/login/login.component';
import { AuthService } from './auth.service';

@NgModule({
  declarations: [LoginComponent],
  imports: [CommonModule],
  providers: [AuthService],
  exports: [LoginComponent]
})
export class AuthModule { }