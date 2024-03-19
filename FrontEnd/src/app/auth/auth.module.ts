import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from '../components/login/login.component';
import { AuthService } from './auth.service';
import { AngularMaterialModule } from '../material.module';

@NgModule({
  declarations: [LoginComponent],
  imports: [CommonModule, AngularMaterialModule ],
  providers: [AuthService],
  exports: [LoginComponent]
})
export class AuthModule { }