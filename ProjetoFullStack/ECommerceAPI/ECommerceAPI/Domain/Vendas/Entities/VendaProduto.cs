using ECommerceAPI.Domain.Produtos.Entities;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ECommerceAPI.Domain.Vendas.Entities
{
    public class VendaProduto
    {
        [Key]
        public int Id { get; set; }

        public int VendaId { get; set; }

        [JsonIgnore]
        public Venda Venda { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
    }
}
