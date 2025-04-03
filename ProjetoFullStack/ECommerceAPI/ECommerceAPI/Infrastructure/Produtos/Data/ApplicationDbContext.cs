using ECommerceAPI.Domain.Clientes.Entities;
using ECommerceAPI.Domain.Produtos.Entities;
using ECommerceAPI.Domain.Vendas.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Infrastructure.Produtos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<VendaProduto> VendaProdutos { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: "Data Source=Banco.sqlite");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Definindo a chave composta
            modelBuilder.Entity<VendaProduto>()
                .HasKey(vp => new { vp.VendaId, vp.ProdutoId });

            // modelBuilder.Entity<VendaProduto>()
            //     .HasOne(vp => vp.Venda)
            //     .WithMany(v => v.VendaProdutos)
            //     .HasForeignKey(vp => vp.VendaId);

            modelBuilder.Entity<VendaProduto>()
                .HasOne(vp => vp.Produto)
                .WithMany()
                .HasForeignKey(vp => vp.ProdutoId);
        }
    }
}
