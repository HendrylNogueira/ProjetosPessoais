import { Component, inject, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Venda } from '../models/venda';
import { Observable, of } from 'rxjs';



@Component({
  selector: 'app-venda',
  imports: [CommonModule, FormsModule, RouterModule],
  templateUrl: './venda.component.html',
  styleUrl: './venda.component.scss'
})
export class VendaComponent {
  http = inject(HttpClient);
  urlApi = 'https://localhost:7240';
  vendas$?: Observable<Venda[]>;
  

  idCliente = 0;
  produtoId = 0;
  quantidade = 0;

  RegistrarVenda(){
      const RegistVenda = {
        
          idVenda: 0,
          idClienteDto: {
            idCliente: this.idCliente
          },
          vendaProdutos: [
            {
              vendaId: 0,
              produtoId: this.produtoId,
              quantidade: this.quantidade,
              precoUnitario: 0,
              produto: null
            }
          ]
        }
  
      this.http.post(`${this.urlApi}/api/Venda`, RegistVenda)
          .subscribe({
            next: () => {
              this.limparCampos();  // Limpa os campos de input
            }
          })
        }

      limparCampos(){
        this.idCliente = 0;
        this.produtoId = 0;  
        this.quantidade = 0;    
      }

}
