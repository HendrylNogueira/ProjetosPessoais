﻿using ECommerceAPI.Domain.Produtos.Entities;

namespace ECommerceAPI.Domain.Vendas.Entities
{
    public class VendaProduto
    {
        public int VendaId { get; set; }
        // public Venda Venda { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

    }
}
