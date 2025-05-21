using ECommerceAPI.Domain.Produtos.Entities;

namespace ECommerceAPI.Domain.Vendas.Entities
{
    public class VendaProdutoDto
    {
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public decimal Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public ProdutoDto Produto { get; set; }
    }
}
