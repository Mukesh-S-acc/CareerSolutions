import { Routes } from '@angular/router';
import { AdminLogin } from './components/admin-login/admin-login';
import { ManageUsers } from './components/manage-users/manage-users';
import { Notifications } from './components/notifications/notifications';

export const routes: Routes = [
  { path: '', component: AdminLogin },
  { path: 'users', component: ManageUsers },
  { path: 'notifications', component: Notifications},
  { path: '**', redirectTo: '' } // fallback
];
