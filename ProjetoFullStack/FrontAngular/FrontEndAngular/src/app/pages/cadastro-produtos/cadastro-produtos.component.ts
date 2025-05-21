import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit } from '@angular/core';
// import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';
import { Produto } from '../../models/produto';
import { Observable, of } from 'rxjs';
import { FormsModule } from '@angular/forms';
import { ProdutoAtualizar } from '../../models/produtoAtualizar';
import { RouterModule } from '@angular/router';



@Component({
  imports: [CommonModule, FormsModule, RouterModule],
  selector: 'app-root',
  // imports: [RouterOutlet],
  templateUrl: './cadastro-produtos.component.html',
  styleUrl: './cadastro-produtos.component.scss'
})


export class CadastroProdutosComponent implements OnInit{

  title = 'FrontEndAngular';
  http = inject(HttpClient);
  urlApi = 'https://localhost:7240';
  produtos$?: Observable<Produto[]>;

  produtoEncontrada$?: Observable<Produto>;
  produtoDeleteEncontrada$?: Observable<Produto>;
  valorBuscaProduto = '';
  valorBuscaProdutoDelete = '';

  IdAdicionar = 0;
  nomeAdicionar = '';
  descricaoAdicionar = '';
  precoAdicionar = 0;
  categoriaAdicionar = '';

  nomeAtualizar = '';
  descricaoAtualizar = '';
  precoAtualizar = 0;
  categoriaAtualizar = '';

  obterProdutoEspecifico(){
    if(!this.valorBuscaProduto)
      return;

    this.produtoEncontrada$ = this.http
    .get<Produto>(`${this.urlApi}/api/Produto/${this.valorBuscaProduto}`)
  }

  obterProdutoDelete(){
    if(!this.valorBuscaProdutoDelete)
      return;

    this.produtoDeleteEncontrada$ = this.http
    .get<Produto>(`${this.urlApi}/api/Produto/${this.valorBuscaProdutoDelete}`)
  }

  ngOnInit(): void {
    this.obterProdutos();
  }

  obterProdutos(){
    this.produtos$ = this.http.get<Produto[]>(`${this.urlApi}/api/produto`)
    
  }

  CadastrarProduto(){
    const addProduto: Produto = {
      id: this.IdAdicionar,
      nome: this.nomeAdicionar,
      descricao: this.descricaoAdicionar,
      preco: this.precoAdicionar,
      categoria: this.categoriaAdicionar
    }
    this.http.post<Produto>(`${this.urlApi}/api/Produto`, addProduto)
    .subscribe({
      next: () => {
        this.obterProdutos(); // Atualiza a lista de produtos
        this.limparCampos();  // Limpa os campos de input
      }})
  }

  deletarProduto() {
    this.obterProdutoDelete(),
    this.http
    .delete<Produto>(`${this.urlApi}/api/Produto/${this.valorBuscaProdutoDelete}`)
    .subscribe(_ => this.obterProdutos())
  }    

  limparCampos(){
    this.IdAdicionar = 0;
    this.nomeAdicionar = '';
    this.descricaoAdicionar = '';
    this.precoAdicionar = 0;
    this.categoriaAdicionar = '';

    this.nomeAtualizar = '';
    this.descricaoAtualizar = '';
    this.precoAtualizar = 0;
    this.categoriaAtualizar = '';

  }

  atualizarProduto(){
    const atualizarNome: Produto = {
      nome: this.nomeAtualizar,
      descricao: this.descricaoAtualizar,
      preco: this.precoAtualizar,
      categoria: this.categoriaAtualizar
    }
    
    this.http.put<Produto>(`${this.urlApi}/api/Produto/${this.valorBuscaProduto}`, atualizarNome).subscribe({
      next: () => {
        this.obterProdutos(); // Atualiza a lista de produtos
        this.limparCampos();  // Limpa os campos de input
      }})
  }
  gavetaAberta = false; // Estado inicial


  toggleGaveta() {
    this.gavetaAberta = !this.gavetaAberta;
  }
}
