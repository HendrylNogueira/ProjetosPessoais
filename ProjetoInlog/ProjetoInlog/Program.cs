namespace ProjetoInlog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();

            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("[1] INSERIR\n" +
                    "[2] EDITAR\n" +
                    "[3] DELETAR\n" +
                    "[4] LISTAR\n" +
                    "[5] FILTRAR\n" +
                    "[99] SAIR");

                Console.Write("Digite qual a opção desejada: ");

                int opcao = int.Parse(Console.ReadLine());

                while (opcao <1 || opcao > 5)
                {
                    if (opcao == 99) { break; }
                    Console.WriteLine("Opção invalida!");
                    Console.Write("Digite qual a opção desejada: ");
                    opcao = int.Parse(Console.ReadLine());
                }
                if (opcao == 1)
                {
                    veiculo.LerDadosDoVeiculo();
                    veiculo.AdicionaVeiculo();
                }

                else if (opcao == 2)
                {
                    veiculo.Editar();
                }

                else if (opcao == 3)
                {
                    veiculo.Deletar();
                }

                else if (opcao == 4)
                {
                    veiculo.ListarVeiculos();
                }

                else if (opcao == 5)
                {
                    veiculo.Filtrar();
                }

                else if (opcao == 99)
                {
                    if (veiculo.ConfirmaSair() == true) { break; }
                }

            }
        }
    }
}