using Microsoft.EntityFrameworkCore;
using ECommerceAPI.Application.Produtos.Interfaces;
using ECommerceAPI.Infrastructure.Produtos.Data;
using ECommerceAPI.Infrastructure.Produtos.Data.Repositories;

namespace ECommerceAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Logging.ClearProviders();
            builder.Logging.AddConsole(); // Registra logs no console



            builder.Services.AddScoped<ApplicationDbContext>();

            builder.Services.AddScoped<IProdutoRepository, ProdutosRepository>();

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.MapControllers();
            app.Run();
        }
    }
}
