namespace ProjetoInlog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();

            while (true)
            {
                Console.WriteLine("[1] INSERIR\n" +
                    "[2] EDITAR\n" +
                    "[3] LISTAR\n" +
                    "[99] SAIR");
                Console.Write("Digite qual a opção desejada: ");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    veiculo.Inserir();
                    veiculo.AdicionaVeiculo();
                }

                else if (opcao == 3)
                {
                    veiculo.Exibir();
                }

                else if (opcao == 99)
                {
                    if (veiculo.ConfirmaSair() == true) { break; }
                }
            }
        }
    }
}