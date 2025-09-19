// import { Component } from '@angular/core';

// @Component({
//   selector: 'app-manage-users',
//   imports: [],
//   templateUrl: './manage-users.html',
//   styleUrl: './manage-users.css'
// })
// export class ManageUsers {

// }


import { Component, OnInit } from '@angular/core';
import { AdminService } from '../../services/admin';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-manage-users',
   standalone: true,              
  imports: [CommonModule],       
  templateUrl: './manage-users.html',
  styleUrl: './manage-users.css'
})
export class ManageUsers implements OnInit {
  users: any[] = [];

  constructor(private adminService: AdminService) {}

  ngOnInit(): void {
    this.loadUsers();
  }

  loadUsers() {
    this.adminService.getUsers().subscribe(data => this.users = data);
  }

  deleteUser(id: number) {
    if (confirm('Are you sure you want to delete this user?')) {
      this.adminService.deleteUser(id).subscribe(() => window.location.reload());
    }
  }
}
