using ECommerceAPI.Domain.Clientes.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Infrastructure.Clientes.Data
{
    public class ClienteApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: "Data Source=Banco.sqlite");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
