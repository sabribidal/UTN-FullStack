import { Component, OnInit } from '@angular/core';
import { NgFor } from '@angular/common';
import { DatosEjerciciosService } from '../datos-ejercicios.service';

@Component({
  selector: 'app-productos',
  standalone: true,
  imports: [NgFor],
  templateUrl: './productos.component.html',
  styleUrl: './productos.component.scss'
})
export class ProductosComponent implements OnInit { 
  listaProductos: any[] = [];

  constructor(private datosService: DatosEjerciciosService) {}

  ngOnInit(): void {
    this.listaProductos = this.datosService.getProductos();
  }
}