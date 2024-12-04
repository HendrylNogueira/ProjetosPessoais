using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using ProjectInlog.Core.Entities.Enum;

namespace ProjectInlog.Core.Entities
{
    public class Veiculo
    {
        [Key]
        public string Chassi { get; private set; }

        public TipoVeiculo Tipo { get; private set; }
        public byte NumeroPassageiros
        {
            get
            {
                return Tipo switch
                {
                    TipoVeiculo.Caminhao => 2,
                    TipoVeiculo.Onibus => 42,
                    _ => 0 // Valor padrão caso nenhum tipo válido seja definido
                };
            }
            private set { }

        }
        public string Cor { get; private set; }

        public void AtualizarChassi(string chassi)
        {
            Chassi = chassi;
        }

        public void AtualizarCor(string cor)
        {
            Cor = cor;
        }

        public void AlterarTipo(TipoVeiculo tipo)
        {
            Tipo = tipo;
            if (Tipo == TipoVeiculo.Onibus)
            {
                NumeroPassageiros = 42;
            }
            else if (Tipo == TipoVeiculo.Caminhao)
            {
                NumeroPassageiros = 2;
            }
        }

        public void AlterarNumeroPassageiros(TipoVeiculo tipo)
        {
            if (Tipo == TipoVeiculo.Onibus)
            {
                NumeroPassageiros = 42;
            }
            else if (Tipo == TipoVeiculo.Caminhao)
            {
                NumeroPassageiros = 2;
            }
        }
    }
}
