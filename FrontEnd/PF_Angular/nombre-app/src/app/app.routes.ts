import { Routes } from '@angular/router';
import { EjerciciosComponent } from './ejercicios/ejercicios.component';
import { MovieListComponent } from './movie-list/movie-list.component'; 

export const routes: Routes = [
  { path: 'pelis', component: MovieListComponent },
  { path: 'ejercicios', component: EjerciciosComponent },
  { path: '', redirectTo: '/ejercicios', pathMatch: 'full' },
  { path: '**', redirectTo: '/ejercicios' }
];