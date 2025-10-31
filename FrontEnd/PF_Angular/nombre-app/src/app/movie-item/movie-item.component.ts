import { Component, Input, Output, EventEmitter } from '@angular/core';
import { NgIf } from '@angular/common';

export interface Movie {
  title: string;
  year: number;
  description: string;
  image?: string; 
}

@Component({
  selector: 'app-movie-item',
  standalone: true,
  imports: [NgIf],
  templateUrl: './movie-item.component.html',
  styleUrl: './movie-item.component.scss'
})
export class MovieItemComponent {
  @Input() movie!: Movie;

  @Output() movieSelected = new EventEmitter<string>();

  selectMovie() {
    this.movieSelected.emit(this.movie.title);
  }
}