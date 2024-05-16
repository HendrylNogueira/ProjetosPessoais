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
        public int Indice;
        public List<object> Veiculos_adicionados = [];
        public List<object> DadosDosVeiculos = [];


        public void Inserir()
        {
            Console.WriteLine("");

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
        }

        public void AdicionaVeiculo()
        {
            DadosDosVeiculos.Add("Chassi");
            Veiculos_adicionados.Add(Chassi);

            DadosDosVeiculos.Add("Tipo");
            Veiculos_adicionados.Add(Tipo);

            DadosDosVeiculos.Add("NumPassageiros");
            Veiculos_adicionados.Add(NumPassageiros);

            DadosDosVeiculos.Add("Cor");
            Veiculos_adicionados.Add(Cor);

        }

        public void Exibir()
        {
            Console.WriteLine(" ");
            for (int item = 1; item <= Veiculos_adicionados.Count; item++)
            {
                Console.WriteLine($"{DadosDosVeiculos[item-1]}: {Veiculos_adicionados[item-1]}");
                if (item % 4 == 0) { Console.WriteLine(""); }
            }

        }

        public bool ConfirmaSair()
        {
            Console.WriteLine(" ");
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

        public void Filtrar()
        {
            Console.WriteLine(" ");
            Console.Write("Digite o Chassi do veículo desejado: ");
            string chassi_para_busca = Console.ReadLine();
            string chassi_em_memoria = " ";
            Indice = 0;

            Console.WriteLine(" ");
            for (int item = 0; item < Veiculos_adicionados.Count; item += 4)
            {
                chassi_em_memoria = (string)Veiculos_adicionados[item];

                if (chassi_em_memoria == chassi_para_busca)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (i == 0) { Indice += item; }
                        Console.WriteLine($"{DadosDosVeiculos[item + i]}: {Veiculos_adicionados[item + i]}");
                    }
                    break;
                }
            }
            if (chassi_para_busca != chassi_em_memoria)
            {
                Console.WriteLine("Chassi não encontrado!");
            }
        }

        public void Deletar()
        {
            Filtrar();
            Console.WriteLine(" ");
            Console.WriteLine("[1] SIM\n" +
                "[2] NAO");
            Console.Write("Deseja realmente deletar o vículo acima?");
            int confirma_del = int.Parse(Console.ReadLine());
            if (confirma_del == 1)
            {
                DadosDosVeiculos.RemoveRange(Indice, Indice +4);
                Veiculos_adicionados.RemoveRange(Indice, Indice +4);
                Console.WriteLine("Veículo deletado.");
            }
        }

        public void Editar()
        {
            Filtrar();
            Console.WriteLine(" ");
            Console.WriteLine("A unica opcao disponivel para editar, é a cor.");
            Console.Write("Digite a nova cor: ");
            Veiculos_adicionados[Indice+3] = Console.ReadLine();
            Console.WriteLine("Cor alterada!");
        }
    }
}
