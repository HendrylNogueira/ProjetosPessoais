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
        public int Valor;
        public string Tipo;
        public byte NumPassageiros;
        public string Cor;
        public List<object> veiculos_adicionados = [];
        public List<object> test = [];


        public void Inserir()
        {
            Console.WriteLine("\nDigite os dados do veículo:");

            Console.Write("\nChassi: ");
            Chassi = Console.ReadLine();

            Console.Write("\n[1] CAMINHAO\n" +
                "[2] ONIBUS\n" +
                "Tipo: ");
            Valor = int.Parse(Console.ReadLine());

            if (Valor == 1)
            {
                Tipo = "CAMINHAO";
                NumPassageiros = 2;
            }
            else if (Valor == 2)
            {
                Tipo = "ONIBUS";
                NumPassageiros = 42;
            }

            Console.Write("\nCor: ");
            Cor = Console.ReadLine();

            Console.WriteLine("");
        }

        public void AdicionaVeiculo()
        {
            test.Add("Chassi");
            veiculos_adicionados.Add(Chassi);

            test.Add("Tipo");
            veiculos_adicionados.Add(Tipo);

            test.Add("NumPassageiros");
            veiculos_adicionados.Add(NumPassageiros);

            test.Add("Cor");
            veiculos_adicionados.Add(Cor);

        }

        public void Exibir()
        {
            Console.WriteLine(" ");
            Console.WriteLine("itens pelo loop:");
            Console.WriteLine(" ");

            for (int item = 1; item <= veiculos_adicionados.Count; item++)
            {
                Console.WriteLine($"{test[item-1]}: {veiculos_adicionados[item-1]}");
                if (item % 4 == 0) { Console.WriteLine(""); }
            }

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
