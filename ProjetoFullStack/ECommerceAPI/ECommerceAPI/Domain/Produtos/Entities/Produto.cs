using ECommerceAPI.Domain.Vendas.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceAPI.Domain.Produtos.Entities
{
    [Table("Produtos")] // 🛠 Força o nome correto da tabela!
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public string Categoria { get; set; }

    }
}