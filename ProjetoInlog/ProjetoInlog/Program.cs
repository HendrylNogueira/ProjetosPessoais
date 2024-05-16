﻿namespace ProjetoInlog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();

            while (true)
            {
                Console.WriteLine("[1] INSERIR\n" +
                    "[2] EDITAR - nok\n" +
                    "[3] DELETAR\n" +
                    "[4] LISTAR\n" +
                    "[5] FILTRAR\n" +
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
                    veiculo.Deletar();
                }

                else if (opcao == 4)
                {
                    veiculo.Exibir();
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