import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class NotificationService {
  private apiUrl = 'http://localhost:5115/api/Notifications';

  constructor(private http: HttpClient) {}


  getNotifications(userId: number): Observable<any[]> {
    return this.http.get<any[]>(`${this.apiUrl}/${userId}`);
  }

  createNotification(note: { userId: number, message: string }): Observable<any> {
    return this.http.post(this.apiUrl, note);
  }

  markAsRead(id: number): Observable<any> {
    return this.http.put(`${this.apiUrl}/mark-read/${id}`, {});
  }

  
}
