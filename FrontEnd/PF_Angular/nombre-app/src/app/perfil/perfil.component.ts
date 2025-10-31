import { Component } from '@angular/core';

@Component({
  selector: 'app-perfil',
  standalone: true,
  imports: [],
  templateUrl: './perfil.component.html',
  styleUrl: './perfil.component.scss'
})
export class PerfilComponent {
  usuario = {
    nombre: 'Alice',
    edad: 30,
    ciudad: 'Buenos Aires',
    rol: 'Desarrolladora Angular'
  };
}