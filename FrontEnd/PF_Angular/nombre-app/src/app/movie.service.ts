import { Injectable } from '@angular/core';
import { Movie } from './movie-item/movie-item.component';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  private moviesData: Movie[] = [
    // ... Tu lista de 10 películas del Ejercicio 7 ...
  ];

  getMovies(): Movie[] {
    return this.moviesData;
  }
}