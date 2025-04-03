using ECommerceAPI.Domain.Clientes.Entities;

namespace ECommerceAPI.Domain.Vendas.Entities
{
    public class VendaDto
    {
        public int IdVenda { get; set; }

        public ClienteDto IdClienteDto { get; set; } // Mantendo a estrutura JSON correta

        public List<VendaProdutoDto> VendaProdutos { get; set; }

    }
}
