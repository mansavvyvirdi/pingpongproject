import { Routes } from '@angular/router'
import { HomeComponent } from './home/home.component';

export const appRoutes: Routes = [
    { path: 'players', component: HomeComponent},
    { path : '', redirectTo:'/players', pathMatch : 'full'}
    
];