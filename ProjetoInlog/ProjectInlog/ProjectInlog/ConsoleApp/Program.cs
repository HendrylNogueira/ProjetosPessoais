using ProjectInlog.Core.Entities;
using Microsoft.EntityFrameworkCore;
using ProjectInlog.Infraestrutura.Data;
using Microsoft.Extensions.DependencyInjection;
using ProjectInlog.Infrastructure.Repositories;
using ProjectInlog.Core.Services;
using ProjectInlog.Core.Entities.Enum;
using Serilog;

namespace ProjectInlog.ConsoleApp
{
    internal class Program
    {
        private static ServiceProvider serviceProvider;

        static void Main(string[] args)
        {
            
            // Exemplo de configuração básica
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug() // Define o nível mínimo dos logs (Debug, Information, Warning, Error, etc.)
                //  .WriteTo.Console() // Grava no console
                .WriteTo.File("logs.txt", rollingInterval: RollingInterval.Day) // Grava em arquivo
                .CreateLogger();


            // Configuração do DbContext para o MySQL usando a string de conexão
            var services = new ServiceCollection();

            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseMySql(
                        "Server=localhost;Database=GerenciamentoFrota;User=root;Password=xnm*2508;", // Sua string de conexão
                        ServerVersion.AutoDetect("Server=localhost;Database=GerenciamentoFrota;User=root;Password=xnm*2508;")
                    )
                )
                .BuildServiceProvider();



            services.AddScoped<IVeiculoRepository, VeiculoRepository>();
            serviceProvider = services.BuildServiceProvider();

            // Testando as operações de CRUD
            var veiculoRepository = serviceProvider.GetService<IVeiculoRepository>();
            VeiculoService veiculoService = new VeiculoService();


            // Interação com o usuário
            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Adicionar Veículo");
                Console.WriteLine("2. Listar Veículos");
                Console.WriteLine("3. Editar Veículo");
                Console.WriteLine("4. Deletar Veículo");
                Console.WriteLine("5. Sair");

                var opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    // Adicionar Veículo
                    Console.Write("Digite o Chassi: ");
                    var chassi = Console.ReadLine();
                    var veiculoObtido = veiculoRepository.ObterVeiculoPorChassi(chassi);
                    if (veiculoObtido == null)
                    {
                        Console.Write("Digite a Cor: ");
                        var cor = Console.ReadLine();
                        Console.Write("Digite o Tipo (Caminhao/Onibus): ");
                        // Validar veículo
                        try
                        {
                            var tipo = (TipoVeiculo)Enum.Parse(typeof(TipoVeiculo), Console.ReadLine());

                            Veiculo veiculo = new Veiculo();

                            veiculo.AtualizarChassi(chassi);
                            veiculo.AtualizarCor(cor);
                            veiculo.AlterarTipo(tipo);
                            veiculoService.ValidarVeiculo(veiculo); // Validando antes de salvar
                            veiculoRepository.AdicionarVeiculo(veiculo); // Salvando o veículo no repositorio
                            Console.WriteLine("Veículo registrado com sucesso! ");
                        }
                        catch (ArgumentException ex)
                        {
                            Log.Error(ex, "Ocorreu um erro no sistema de gerenciamento de frota.");
                            Console.WriteLine($"Erro de validação: {ex.Message}");
                        }
                        
                    }
                    else 
                    { Console.WriteLine("Veículo já cadastrado!"); continue; }
                    
                }
                else if (opcao == "2")
                {
                    // Listar Veículos
                    var veiculos = veiculoRepository.ObterTodosVeiculos();
                    foreach (var veiculo in veiculos)
                    {
                        Console.WriteLine($"Chassi: {veiculo.Chassi}, Cor: {veiculo.Cor}, Tipo: {veiculo.Tipo}, Passageiros: {veiculo.NumeroPassageiros}");
                    }
                }
                else if (opcao == "3")
                {
                    // Atualizar Veículo
                    Console.Write("Digite o Chassi do Veículo a ser atualizado: ");
                    var chassi = Console.ReadLine();
                    var veiculoObtido = veiculoRepository.ObterVeiculoPorChassi(chassi);

                    if (veiculoObtido != null)
                    {
                        Console.WriteLine("Disponivel apenas a edicao de cor.");
                        Console.Write("Digite a nova Cor: ");
                        var cor = Console.ReadLine();
                        veiculoObtido.AtualizarCor(cor);
                        veiculoRepository.AtualizarVeiculo(veiculoObtido);

                        //  VeiculoRepository.AtualizarVeiculo();
                        Console.WriteLine("Veículo atualizado com sucesso!");
                    }
                    else
                    {
                        Log.Error("Veículo nao encontrado.");
                        Console.WriteLine("Veículo não encontrado!"); continue; }

                }
                else if (opcao == "4")
                {
                    // Deletar Veículo
                    Console.Write("Digite o Chassi do Veículo a ser deletado: ");
                    var chassi = Console.ReadLine();

                    var veiculoObtido = veiculoRepository.ObterVeiculoPorChassi(chassi);
                    if (veiculoObtido != null)
                    {
                        veiculoRepository.RemoverVeiculo(chassi);
                        Console.WriteLine("Veículo deletado com sucesso!");
                    }
                    else
                    {
                        Log.Error("Veículo nao encontrado.");
                        Console.WriteLine("Veículo não encontrado!"); continue; }
                }

                else if (opcao == "5")
                {
                    Console.WriteLine("Realmente deseja sair?");
                    Console.WriteLine("1. Sim");
                    Console.WriteLine("2. Não");
                    int confirSaida = int.Parse(Console.ReadLine());
                    if (confirSaida == 1)
                    {
                        break;  // Sair
                    }
                    else continue;
                }
                else
                {
                    Log.Error("Opcao invalida.");
                    Console.WriteLine("Opção inválida!");
                }

            }
        }
    }
}