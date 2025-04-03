using ECommerceAPI.Application.Vendas.Interfaces;
using ECommerceAPI.Domain.Vendas.Entities;
using ECommerceAPI.Infrastructure.Vendas.Data;
using Microsoft.EntityFrameworkCore;


namespace ECommerceAPI.Infrastructure.Vendas.Data.Repositories
{
    public class VendaRepository : IVendasRepository
    {
        private readonly VendasDbContext _context;

        public VendaRepository(VendasDbContext context) 
        { 
            _context = context;
        }

        public async Task<IEnumerable<Venda>> GetAllVendasAsync()
        {
            return await _context.Vendas.ToListAsync();
        }

        public async Task AddVendaAsync(Venda venda)
        {
            await _context.Vendas.AddAsync(venda);
            await _context.SaveChangesAsync();
        }
    }
}
    