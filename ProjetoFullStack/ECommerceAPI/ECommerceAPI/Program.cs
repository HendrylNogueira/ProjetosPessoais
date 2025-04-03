using Microsoft.EntityFrameworkCore;
using ECommerceAPI.Application.Produtos.Interfaces;
using ECommerceAPI.Infrastructure.Produtos.Data;
using ECommerceAPI.Infrastructure.Produtos.Data.Repositories;
using ECommerceAPI.Infrastructure.Clientes.Data;
using ECommerceAPI.Application.Clientes.Interfaces;
using ECommerceAPI.Infrastructure.Clientes.Data.Repositories;
using ECommerceAPI.Infrastructure.Vendas.Data.Repositories;
using ECommerceAPI.Infrastructure.Vendas.Data;
using ECommerceAPI.Domain.Vendas.Entities;
using ECommerceAPI.Application.Vendas.Interfaces;

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
            builder.Services.AddScoped<ClienteApplicationDbContext>();
            builder.Services.AddScoped<VendasDbContext>();

            builder.Services.AddScoped<IProdutoRepository, ProdutosRepository>();
            builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
            builder.Services.AddScoped<IVendasRepository, VendaRepository>();


            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors(option => 
                option.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyOrigin();
                    policy.AllowAnyMethod();
                    policy.AllowAnyHeader();
                }));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors();
            app.MapControllers();
            app.Run();
        }
    }
}
