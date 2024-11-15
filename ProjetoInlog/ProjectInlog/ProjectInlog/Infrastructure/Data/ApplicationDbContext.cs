using Microsoft.EntityFrameworkCore;
using ProjectInlog.Core.Entities;

namespace ProjectInlog.Infraestrutura.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        // Construtor que aceita as opções de configuração do DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Definindo as tabelas que o DbContext vai gerenciar
        public DbSet<Veiculo> Veiculos { get; set; }

        // Ou adicione o método OnConfiguring, se necessário
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Configure o provedor aqui se não estiver usando DI
                optionsBuilder.UseMySql(
                    "Server=localhost;Database=GerenciamentoFrota;User=root;Password=xnm*2508;",
                    ServerVersion.AutoDetect("Server=localhost;Database=GerenciamentoFrota;User=root;Password=xnm*2508;")
                );
            }
        }
    }
}
