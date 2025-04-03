using ECommerceAPI.Application.Clientes.Interfaces;
using ECommerceAPI.Domain.Clientes.Entities;
using ECommerceAPI.Infrastructure.Produtos.Data;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Infrastructure.Clientes.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ClienteRepository> _logger;

        public ClienteRepository(ApplicationDbContext context, ILogger<ClienteRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IEnumerable<Cliente>> GetAllClientesAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> GetClienteByIdAsync(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task AddClienteAsync(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateClienteAsync(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteClienteAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

    }
}
