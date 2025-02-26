using ECommerceAPI.Application.Produtos.Interfaces;
using ECommerceAPI.Domain.Produtos.Entities;
using ECommerceAPI.Infrastructure.Produtos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ECommerceAPI.Infrastructure.Produtos.Data.Repositories
{
    public class ProdutosRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ProdutosRepository> _logger;


        public ProdutosRepository(ApplicationDbContext context, ILogger<ProdutosRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<Produto>> GetAllProdutosAsync()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> GetProdutoByIdAsync(int id)
        {
            return await _context.Produtos.FindAsync(id);
        }

        public async Task AddProdutoAsync(Produto produto)
        {
            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProdutoAsync(Produto produto)
        {
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProdutoAsync(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }
        }

    }
}
