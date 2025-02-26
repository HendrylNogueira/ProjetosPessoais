using ECommerceAPI.Domain.Produtos.Entities;

namespace ECommerceAPI.Application.Produtos.Interfaces
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetAllProdutosAsync();
        Task<Produto> GetProdutoByIdAsync(int id);
        Task AddProdutoAsync(Produto produto);
        Task UpdateProdutoAsync(Produto produto);
        Task DeleteProdutoAsync(int id);
    }
}
