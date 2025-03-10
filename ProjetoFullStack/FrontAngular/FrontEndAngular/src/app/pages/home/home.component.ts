import { Component } from '@angular/core';
import { RouterModule } from '@angular/router'; // Importando RouterModule

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss',
  imports: [RouterModule], // Importando o RouterModule para habilitar o routerLink
})
export class HomeComponent {

}
