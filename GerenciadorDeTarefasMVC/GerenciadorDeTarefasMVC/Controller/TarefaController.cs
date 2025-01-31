using GerenciadorDeTarefasMVC.Model;
using GerenciadorDeTarefasMVC.View;

namespace GerenciadorDeTarefasMVC.Controller
{
    public class TarefaController
    {
        private List<Tarefa> Tarefas = new List<Tarefa>();
        private TarefaView view = new TarefaView();
        public void AdicionarTarefa()
        {
            Tarefa tarefa = view.ObterDadosTarefa();
            Tarefas.Add(tarefa);
            view.MostrarMensagem("Tarefa adicionada com sucesso! ");
        }

        public void ListarTarefas()
        {
            view.ListarTarefas(Tarefas);
        }
    }
}
