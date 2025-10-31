import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DatosEjerciciosService {

  private listaProductos = [
    { id: 1, nombre: 'Laptop', precio: 1200, stock: 5 },
    { id: 2, nombre: 'Mouse', precio: 25, stock: 50 },
    { id: 3, nombre: 'Teclado', precio: 75, stock: 30 },
    { id: 4, nombre: 'Monitor', precio: 300, stock: 10 }
  ];

  getProductos() {
    return this.listaProductos;
  }
}