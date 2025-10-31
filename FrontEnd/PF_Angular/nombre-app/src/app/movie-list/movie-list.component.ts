import { Component, OnInit } from '@angular/core';
import { NgFor } from '@angular/common';
import { MovieItemComponent, Movie } from '../movie-item/movie-item.component';
import { MovieService } from '../movie.service';

@Component({
  selector: 'app-movie-list',
  standalone: true,
  imports: [NgFor, MovieItemComponent],
  templateUrl: './movie-list.component.html',
  styleUrl: './movie-list.component.scss'
})
export class MovieListComponent implements OnInit {
  movies: Movie[] = [];
  selectedMovie: string = 'Ninguna';

  constructor(private movieService: MovieService) {}

  ngOnInit(): void {
    this.movies = this.movieService.getMovies();
  }

  onMovieSelected(movieTitle: string) {
    this.selectedMovie = movieTitle;
  }
}