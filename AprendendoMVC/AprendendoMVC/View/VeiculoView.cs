using AprendendoMVC.Model; 
using System.Runtime.ConstrainedExecution;


namespace AprendendoMVC.View
{
    public class VeiculoView
    {
        public Veiculo ObterDadosVeiculo()
        {
            Console.WriteLine("Informe o chassi do veículo:");
            string chassi = Console.ReadLine();

            Console.WriteLine("Informe o tipo do veículo [Caminhão ou Onibus]: ");
            string tipo = Console.ReadLine();

            Console.WriteLine("Informe o numero de passageiros [2 para caminhao ou 42 para onibus]");
            int numeroPassageiros = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a cor do veículo:");
            string cor = Console.ReadLine();


            return new Veiculo
            {
                Chassi = chassi,
                Tipo = tipo,
                NumeroPassageiros = numeroPassageiros,
                Cor = cor
            };
        }

        public void MostrarListaVeiculos(List<Veiculo> veiculos)
        {
            Console.WriteLine("\nLista de Veículos:");
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo cadastrado.");
                return;
            }

            foreach (var veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }

        public void MostrarMensagem(string mensagem)
        {
            Console.WriteLine($"\n{mensagem}");
        }
    }
}
