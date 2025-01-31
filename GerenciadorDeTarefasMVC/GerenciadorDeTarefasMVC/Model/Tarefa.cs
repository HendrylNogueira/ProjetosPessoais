namespace GerenciadorDeTarefasMVC.Model
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Prazo { get; set; }
        public bool Concluida { get; set; }

        public Tarefa()
        {
        }

        public Tarefa(int id, string nome, string descricao, int prazo, bool concluida)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Prazo = prazo;
            Concluida = concluida;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Nome}, Descrição: {Descricao}, Prazo: {Prazo}, Concluida: {Concluida}";
        }
    }
}
