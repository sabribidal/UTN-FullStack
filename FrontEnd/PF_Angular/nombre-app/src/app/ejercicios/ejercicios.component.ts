import { Component } from '@angular/core';
import { MensajeComponent } from '../mensaje/mensaje.component';
import { PerfilComponent } from '../perfil/perfil.component';
import { ProductosComponent } from '../productos/productos.component';

@Component({
  selector: 'app-ejercicios',
  standalone: true,
  imports: [MensajeComponent, PerfilComponent, ProductosComponent],
  templateUrl: './ejercicios.component.html',
  styleUrl: './ejercicios.component.scss'
})
export class EjerciciosComponent {

}
