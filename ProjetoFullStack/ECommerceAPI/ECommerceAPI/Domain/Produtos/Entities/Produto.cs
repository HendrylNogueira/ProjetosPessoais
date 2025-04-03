﻿using ECommerceAPI.Domain.Vendas.Entities;

namespace ECommerceAPI.Domain.Produtos.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public string Categoria { get; set; }

    }
}