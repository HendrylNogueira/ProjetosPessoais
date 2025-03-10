import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit } from '@angular/core';
// import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';
import { Produto } from './models/produto';
import { Observable, of } from 'rxjs';
import { FormsModule } from '@angular/forms';
import { ProdutoAtualizar } from './models/produtoAtualizar';
import { RouterModule } from '@angular/router';


@Component({
  imports: [CommonModule, FormsModule, RouterModule],


  selector: 'app-root',
  // imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})


export class AppComponent{
  title = 'FrontEndAngular';
  http = inject(HttpClient);
  urlApi = 'https://localhost:7240';
  produtos$?: Observable<Produto[]>;

  
}
