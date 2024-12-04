using ProjectInlog.Core.Entities;
using Serilog;

namespace ProjectInlog.Core.Services
{
    public class VeiculoService
    {
        // Método para validar o veiculo
        public void ValidarVeiculo(Veiculo veiculo)
        {
            if (string.IsNullOrWhiteSpace(veiculo.Chassi))
            {
                Log.Error("Ocorreu um erro no sistema de gerenciamento de frota.");
                throw new ArgumentException("O chassi não pode ser vazio ou nulo.");
            }

            if (veiculo.Chassi.Length != 5) // Supondo que o chassi tenha 5 caracteres
            {
                Log.Error("Ocorreu um erro no sistema de gerenciamento de frota.");
                throw new ArgumentException("O chassi deve ter exatamente 5 caracteres.");
            }
        }
    }
}
