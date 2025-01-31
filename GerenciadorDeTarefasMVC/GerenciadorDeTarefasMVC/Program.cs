using GerenciadorDeTarefasMVC.Controller;

namespace GerenciadorDeTarefasMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var controller = new TarefaController();

            while (true)
            {
                Console.WriteLine("\nGerenciador de Tarefas");
                Console.WriteLine("1. Adicionar Tarefa");
                Console.WriteLine("2. Listar Tarefas");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao) 
                {
                    case "1":
                        controller.AdicionarTarefa();
                        break;
                    case "2":
                        controller.ListarTarefas();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente. ");
                        break;
                }
            }
        }
    }
}
