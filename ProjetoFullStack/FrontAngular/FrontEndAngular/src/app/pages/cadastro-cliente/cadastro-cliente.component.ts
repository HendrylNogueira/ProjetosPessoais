import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';

import { Component, inject, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { Cliente } from '../../models/cliente';
import { ClienteAtualizar } from '../../models/clienteAtualizar';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';



@Component({
  selector: 'app-cadastro-cliente',
  imports: [CommonModule, FormsModule,RouterModule],
  templateUrl: './cadastro-cliente.component.html',
  styleUrl: './cadastro-cliente.component.scss'
})
export class CadastroClienteComponent implements OnInit {
  http = inject(HttpClient);
  urlApi = 'https://localhost:7240';
  clientes$?: Observable<Cliente[]>;

  clienteEncontrado$?: Observable<Cliente>;
  clienteDeleteEncontrado$?: Observable<Cliente>;
  valorBuscaCliente = '';
  valorBuscaClienteDelete = '';

  IdAdicionar = 0;
  nomeAdicionar = '';
  enderecoAdicionar = '';
  telefoneAdicionar = '';

  telefoneAtualizar = '';
  

  obterClienteEspecifico(){
    if(!this.valorBuscaCliente)
      return;

    this.clienteEncontrado$ = this.http
    .get<Cliente>(`${this.urlApi}/api/Cliente/${this.valorBuscaCliente}`)
  }

  obterClienteDelete(){
    if(!this.valorBuscaClienteDelete)
      return;

    this.clienteDeleteEncontrado$ = this.http
    .get<Cliente>(`${this.urlApi}/api/Cliente/${this.valorBuscaClienteDelete}`)
  }

  CadastrarCliente(){
    const addCliente: Cliente = {
      id: this.IdAdicionar,
      nome: this.nomeAdicionar,
      endereco: this.enderecoAdicionar,
      telefone: this.telefoneAdicionar,
    }
    this.http.post<Cliente>(`${this.urlApi}/api/Cliente`, addCliente)
    .subscribe({
      next: () => {
        this.obterClientes(); // Atualiza a lista de produtos
        this.limparCampos();  // Limpa os campos de input
      }})
  }

  deletarCliente() {
    this.obterClienteDelete(),
    this.http
    .delete<Cliente>(`${this.urlApi}/api/Cliente/${this.valorBuscaClienteDelete}`)
    .subscribe(_ => this.obterClientes())
  }    

  atualizarCliente(){
    const atualizarTelefone: ClienteAtualizar = {
      telefone: this.telefoneAtualizar
    }
    
    this.http.put<Cliente>(`${this.urlApi}/api/Cliente/${this.valorBuscaCliente}`, atualizarTelefone).subscribe({
      next: () => {
        this.obterClientes(); // Atualiza a lista de produtos
        this.limparCampos();  // Limpa os campos de input
      }})
  }

  ngOnInit(): void {
    this.obterClientes();
  }
  obterClientes(){
    this.clientes$ = this.http.get<Cliente[]>(`${this.urlApi}/api/Cliente`)
  }

  limparCampos(){
    this.IdAdicionar = 0;
    this.nomeAdicionar = '';
    this.enderecoAdicionar = '';
    this.telefoneAdicionar = '';

    this.telefoneAtualizar = '';

    this.valorBuscaCliente = '';
  }

  gavetaAberta = false; // Estado inicial

  toggleGaveta() {
    this.gavetaAberta = !this.gavetaAberta;
  }
}
