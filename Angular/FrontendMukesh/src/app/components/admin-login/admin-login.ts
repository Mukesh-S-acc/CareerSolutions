// import { Component } from '@angular/core';

// @Component({
//   selector: 'app-admin-login',
//   imports: [],
//   templateUrl: './admin-login.html',
//   styleUrl: './admin-login.css'
// })
// export class AdminLogin {

// }

import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AdminAuthService } from '../../services/admin-auth';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-admin-login',
    standalone: true,              
  imports: [FormsModule],         
  templateUrl: './admin-login.html',
  styleUrl : './admin-login.css'
})
export class AdminLogin {
  username = '';
  password = '';
  error = '';

  constructor(private authService: AdminAuthService, private router: Router) {}

  login() {
    
    this.authService.login({ username: this.username, password: this.password })
    .subscribe({
        next: res => {
          alert('Login successful');
          this.router.navigate(['/users']);
        },
        error: err => this.error = 'Invalid credentialss'
      });
  }

  
}
