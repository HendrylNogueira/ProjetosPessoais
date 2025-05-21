import { RouterModule,Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { CadastroProdutosComponent } from './pages/cadastro-produtos/cadastro-produtos.component';
import { CadastroClienteComponent } from './pages/cadastro-cliente/cadastro-cliente.component';
import { HomeComponent } from '../app/pages/home/home.component'
import { ContatoComponent } from './pages/contato/contato.component';
import { VendaComponent } from './pages/venda/venda.component';
import { RelatorioVendaComponent } from './pages/relatorios/relatorio-venda/relatorio-venda.component';


export const routes: Routes = [
  { path: 'cadastro-produtos', component: CadastroProdutosComponent },
  { path: 'cadastro-clientes', component: CadastroClienteComponent },
  { path: 'home', component: HomeComponent },
  {path: 'contato', component: ContatoComponent},
  {path: 'venda', component: VendaComponent},
  {path: 'relatorio-venda', component: RelatorioVendaComponent},
  { path: '', redirectTo: '/home', pathMatch: 'full' }, // Rota padrão
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
  })
  export class AppRoutingModule { }