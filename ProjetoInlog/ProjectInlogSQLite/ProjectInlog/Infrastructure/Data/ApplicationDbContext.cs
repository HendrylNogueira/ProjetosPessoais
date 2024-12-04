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
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\"); // Volta três níveis para sair do bin/debug/netX.X
            string dbPath = Path.Combine(projectPath, "meubanco.db");
            if (!optionsBuilder.IsConfigured)
            {
                // Configure o provedor aqui se não estiver usando DI
                optionsBuilder.UseSqlite($"Data Source={Path.GetFullPath(dbPath)}");
            }
        }
        
    }
}
