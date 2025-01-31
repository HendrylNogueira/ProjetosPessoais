using AprendendoMVC.Controller;

namespace AprendendoMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var controller = new VeiculoController();

            while (true)
            {
                Console.WriteLine("\nGerenciamento de Frota");
                Console.WriteLine("1. Adicionar Veículo");
                Console.WriteLine("2. Listar Veículos");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        controller.AdicionarVeiculo();
                        break;
                    case "2":
                        controller.ListarVeiculos();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }
        }
    }
}
