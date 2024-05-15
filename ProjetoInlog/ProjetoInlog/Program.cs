namespace ProjetoInlog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();
            BancodeDados dados = new BancodeDados();

            while (true)
            {
                Console.WriteLine("[1] INSERIR\n" +
                    "[2] EDITAR\n" +
                    "[99] SAIR");
                Console.Write("Digite qual a opção desejada: ");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    veiculo.Inserir();
                    veiculo.AdicionaVeiculo();
                }

                else if (opcao == 99)
                {
                    if (veiculo.ConfirmaSair() == true) { break; }
                }
            }
            veiculo.Exibir();
        }
    }
}