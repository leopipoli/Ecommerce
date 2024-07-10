import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private isAuthenticated: boolean = false;

  constructor() {}

  login(username: string, password: string): boolean {
    // Lógica para verificar se as credenciais são válidas
    if (username === 'admin' && password === 'admin') {
      this.isAuthenticated = true;
      return true;
    } else {
      this.isAuthenticated = false;
      return false;
    }
  }

  logout(): void {
    this.isAuthenticated = false;
  }

  authenticated(): boolean {
    return this.isAuthenticated;
  }
}
