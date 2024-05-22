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
        public int IdTipoVeiculo;
        public string TipoVeiculo;
        public byte NumPassageiros;
        public string Cor;
        public int Indice;
        public List<object> VeiculosAdicionados = [];
        public List<object> IdVeiculosAdicionados = [];


        public void LerDadosDoVeiculo()
        {
            Console.WriteLine("");

            Console.WriteLine("Digite os dados do veículo:");

            Console.Write("\nChassi: ");
            Chassi = Console.ReadLine();

            Console.Write("\n[1] CAMINHAO\n" +
                "[2] ONIBUS\n" +
                "Tipo: ");
            IdTipoVeiculo = int.Parse(Console.ReadLine());

            while (IdTipoVeiculo <1 || IdTipoVeiculo > 2)
            {
                Console.WriteLine("Opção invalida!");
                Console.Write("Digite qual a opção desejada: ");
                IdTipoVeiculo = int.Parse(Console.ReadLine());
            }

            if (IdTipoVeiculo == 1)
            {
                TipoVeiculo = "CAMINHAO";
                NumPassageiros = 2;
            }
            else if (IdTipoVeiculo == 2)
            {
                TipoVeiculo = "ONIBUS";
                NumPassageiros = 42;
            }

            Console.Write("\nCor: ");
            Cor = Console.ReadLine();
        }

        public void AdicionaVeiculo()
        {
            if (VeiculosAdicionados.Contains(Chassi))
            {
                Console.WriteLine("Nao foi possivel completar a operacao.");
                Console.WriteLine("Veículo duplicado");
            }

            else
            {
                IdVeiculosAdicionados.Add("Chassi");
                VeiculosAdicionados.Add(Chassi);

                IdVeiculosAdicionados.Add("Tipo");
                VeiculosAdicionados.Add(TipoVeiculo);

                IdVeiculosAdicionados.Add("NumPassageiros");
                VeiculosAdicionados.Add(NumPassageiros);

                IdVeiculosAdicionados.Add("Cor");
                VeiculosAdicionados.Add(Cor);
            }
        }

        public void ListarVeiculos()
        {
            Console.WriteLine(" ");
            for (int item = 1; item <= VeiculosAdicionados.Count; item++)
            {
                Console.WriteLine($"{IdVeiculosAdicionados[item-1]}: {VeiculosAdicionados[item-1]}");

                // Pula uma linha após listar os dados de um veículo
                if (item % 4 == 0) { Console.WriteLine(""); } 
            }
            if (VeiculosAdicionados.Count == 0)
            {
                Console.WriteLine("Nenhum veiculo adicionado.");
            }

        }

        public bool ConfirmaSair()
        {
            Console.WriteLine(" ");
            Console.WriteLine("\nDeseja realmente sair? ");
            Console.Write("[1] Não\n" +
                "[2] Sim:\n" +
                "R:");
            int confirmacao_saida = int.Parse(Console.ReadLine());
            if (confirmacao_saida == 2)
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
            string chassi_salvo_na_lista_veiculos = " ";
            Indice = 0;

            Console.WriteLine(" ");
            for (int item = 0; item < VeiculosAdicionados.Count; item += 4)
            {
                // Pega o primeiro chassi salvo e atribui na variavel
                chassi_salvo_na_lista_veiculos = (string)VeiculosAdicionados[item];

                if (chassi_salvo_na_lista_veiculos == chassi_para_busca)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (i == 0) { Indice += item; }
                        Console.WriteLine($"{IdVeiculosAdicionados[item + i]}: {VeiculosAdicionados[item + i]}");
                    }
                    break;
                }
            }
            if (chassi_para_busca != chassi_salvo_na_lista_veiculos)
            {
                Console.WriteLine("Chassi não encontrado!");
                Indice = 999;
            }
        }

        public void Deletar()
        {
            // Primeiro filtra o veículo pelo chassi
            Filtrar();

            if (Indice != 999)
            {
                Console.WriteLine(" ");
                Console.WriteLine("[1] SIM\n" +
                    "[2] NAO");
                Console.Write("Deseja realmente deletar o veículo acima?");

                // solicita confirmacao para deletar, caso for sim, deleta o veículo
                int confirma_del = int.Parse(Console.ReadLine());
                if (confirma_del == 1)
                {
                    IdVeiculosAdicionados.RemoveRange(Indice, Indice + 4);
                    VeiculosAdicionados.RemoveRange(Indice, Indice + 4);
                    Console.WriteLine("Veículo deletado.");
                }
            }
        }

        public void Editar()
        {
            Filtrar();
            if (Indice != 999)
            {
                Console.WriteLine(" ");
                Console.WriteLine("A unica opcao disponivel para editar, é a cor.");
                Console.Write("Digite a nova cor: ");
                VeiculosAdicionados[Indice + 3] = Console.ReadLine();
                Console.WriteLine("Cor alterada!");
            }
            
        }

    }
}
