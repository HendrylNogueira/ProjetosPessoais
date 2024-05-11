using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInlog
{
    internal class Veiculo
    {
        public string Chassi;
        public int Tipo;
        public byte NumPassageiros;
        public string Cor;

        public object[,] BancoDeDados = new object[2, 4];

        public void Inserir()
        {
            Console.WriteLine("\nDigite os dados do veículo:");

            Console.Write("\nChassi: ");
            Chassi = Console.ReadLine();

            Console.Write("\n[1] CAMINHAO\n" +
                "[2] ONIBUS\n" +
                "Tipo: ");
            Tipo = int.Parse(Console.ReadLine());

            if (Tipo == 1)
            {
                NumPassageiros = 2;
            }
            else if (Tipo == 2)
            {
                NumPassageiros = 42;
            }

            Console.Write("\nCor: ");
            Cor = Console.ReadLine();

            Console.WriteLine("");
        }

        public bool ConfirmaSair()
        {
            Console.WriteLine("\nDeseja realmente sair? ");
            Console.Write("[1] Não\n" +
                "[2] Sim:\n" +
                "R:");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 2)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }
}
