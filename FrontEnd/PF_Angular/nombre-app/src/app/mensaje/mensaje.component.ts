import { Component } from '@angular/core';
import { NgIf } from '@angular/common';

@Component({
  selector: 'app-mensaje',
  standalone: true, 
  imports: [NgIf], 
  templateUrl: './mensaje.component.html',
  styleUrl: './mensaje.component.scss'
})
export class MensajeComponent {
  mensaje1: string = 'Este mensaje siempre se muestra.'; 
  mensaje2: string = 'Este mensaje se oculta con ngIf.'; 
  ocultarMensaje: boolean = true; 
}