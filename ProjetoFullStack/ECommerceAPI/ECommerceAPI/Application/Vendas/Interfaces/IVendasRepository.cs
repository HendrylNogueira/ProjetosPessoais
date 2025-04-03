using ECommerceAPI.Domain.Vendas.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Application.Vendas.Interfaces
{
    public interface IVendasRepository
    {
        Task<IEnumerable<Venda>> GetAllVendasAsync();
        Task AddVendaAsync(Venda venda);
    }
}
