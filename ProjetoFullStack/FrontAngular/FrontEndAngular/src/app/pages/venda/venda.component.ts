import { Component, inject, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Venda } from '../../models/venda';
import { Observable, BehaviorSubject  } from 'rxjs';
import { Cliente } from '../../models/cliente';
import { Produto } from '../../models/produto';
import { switchMap, map } from 'rxjs/operators';



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
  

  valorBuscaProduto = '';
  produtoEncontrada$?: Observable<Produto>;

  idClienteAdicionar = 1;
  idProdutoAdicionar = 0;

  quantidadeAdicionar = 1.0;

  produtos$!: Observable<Produto[]>;
  produtoSelecionado = '';

  produtoPorCategoria$?: Observable<Produto[]>;
  categoriaAdicionar = '';

  private categoriaSelecionada$ = new BehaviorSubject<string>(this.categoriaAdicionar);


  ngOnInit(): void{
    this.buscarProdutos();
    this.produtoPorCategoria$ = this.categoriaSelecionada$.pipe(
      switchMap(categoria =>
        this.http.get<Produto[]>(`${this.urlApi}/api/produto`).pipe(
      map(produtos => produtos.filter(p => p.categoria === categoria ))
        )
      )
    );
  }
  
  onCategoriaChange(): void {
    this.categoriaSelecionada$.next(this.categoriaAdicionar);
    this.idProdutoAdicionar = 0; // reseta seleção
  }


  
  buscarProdutos(){
    this.produtos$ = this.http.get<Produto[]>(`${this.urlApi}/api/produto`)
  }

  RegistrarVenda(){
      const RegistVenda = {
        
          idVenda: 0,
          idClienteDto: {
            idCliente: this.idClienteAdicionar
          },
          vendaProdutos: [
            {
              vendaId: 0,
              produtoId: this.idProdutoAdicionar,
              quantidade: this.quantidadeAdicionar,
              precoUnitario: 0,
              produto: {
                id: 0,
                nome: " ",
                descricao: " ",
                preco: 0,
                categoria: " "
              }
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
        this.idClienteAdicionar = 1;
        this.idProdutoAdicionar = 0;  
        this.quantidadeAdicionar = 1.0;    
      }

      nomeCliente: string = '';
      enderecoCliente: string = '';
      telefoneCliente: string = '(__) _____-____';

      buscarClientePorId() {
        this.http.get<Cliente>(`${this.urlApi}/api/Cliente/${this.idClienteAdicionar}`)
        .subscribe(cliente => {this.nomeCliente = cliente.nome, this.enderecoCliente = cliente.endereco, this.telefoneCliente = cliente.telefone;
        }, err => {
          this.nomeCliente = 'Cliente não encontrado';
          this.enderecoCliente = '';
          this.telefoneCliente = '(__) _____-____'
        });
      }

      obterProdutoEspecifico(){
          if(!this.valorBuscaProduto)
            return;
      
          this.produtoEncontrada$ = this.http
          .get<Produto>(`${this.urlApi}/api/Produto/${this.valorBuscaProduto}`)
        }
}