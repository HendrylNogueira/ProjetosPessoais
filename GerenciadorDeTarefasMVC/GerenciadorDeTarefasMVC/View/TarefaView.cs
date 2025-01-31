using GerenciadorDeTarefasMVC.Model;
namespace GerenciadorDeTarefasMVC.View
{
    public class TarefaView
    {
        public Tarefa ObterDadosTarefa()
        {
            Console.WriteLine("Digite o ID da tarefa: ");
            int id = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o nome da tarefa: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a descrição da tarefa: ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Digite o prazo da tarefa em horas: ");
            float prazo = float.Parse(Console.ReadLine());

            Console.WriteLine("A tarefa está concluida? [S/N]: ");
            string resposta = Console.ReadLine();
            bool concluida = false;
            if (resposta == "S" || resposta == "Sim" || resposta == "sim")
            {
                concluida= true;
            }
            
            return new Tarefa
            {
                Id = id,
                Nome = nome,
                Descricao = descricao,
                Prazo = prazo,
                Concluida = concluida
            };
        }

        public void ListarTarefas(List<Tarefa> tarefa)
        {
            Console.WriteLine("\nLista de tarefas");
            if (tarefa.Count == 0)
            {
                Console.WriteLine("Não há itens na lista.");
            }

            foreach (var t in tarefa)
            {
                Console.WriteLine(t);
            }
        }
        public void MostrarMensagem(string mensagem)
        {
            Console.WriteLine($"\n{mensagem}");
        }
    }
}
