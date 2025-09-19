// import { Component } from '@angular/core';

// @Component({
//   selector: 'app-notifications',
//   imports: [],
//   templateUrl: './notifications.html',
//   styleUrl: './notifications.css'
// })
// export class Notifications {

// }


import { Component, OnInit } from '@angular/core';
import { NotificationService } from '../../services/notification';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-notifications',
    standalone: true,           
  imports: [CommonModule],   
  templateUrl: './notifications.html',
  styleUrl: './notifications.css'
})
export class Notifications implements OnInit {
  notifications: any[] = [];
  userId = 1; 

  constructor(private notificationService: NotificationService) {}

  ngOnInit(): void {
    this.loadNotifications();
  }

  loadNotifications() {
    this.notificationService.getNotifications(this.userId).subscribe({
      next: data => {
        // console.log('Notifications fetched:', data); 
        this.notifications = data;
      },
      error: err => console.error('Error fetching notifications', err)
    });
  }
  

  markAsRead(id: number) {
    this.notificationService.markAsRead(id).subscribe(() => this.loadNotifications());
  }
}
