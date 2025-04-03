using ECommerceAPI.Domain.Clientes.Entities;
using ECommerceAPI.Domain.Produtos.Entities;
using System.ComponentModel.DataAnnotations;

namespace ECommerceAPI.Domain.Vendas.Entities
{
    public class Venda
    {
        [Key] // 🚀 Define explicitamente que este é o ID primário
        public int Id { get; set; }
        public int ClienteId { get; set; }

        public List<VendaProduto> VendaProdutos { get; set; } = new List<VendaProduto>();

    }
}
// 
