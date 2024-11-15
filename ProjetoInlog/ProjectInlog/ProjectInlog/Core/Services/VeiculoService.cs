using ProjectInlog.Core.Entities;

namespace ProjectInlog.Core.Services
{
    internal class VeiculoService
    {
        // Método para validar o veiculo
        public void ValidarVeiculo(Veiculo veiculo)
        {
            if (string.IsNullOrWhiteSpace(veiculo.Chassi))
            {
                throw new ArgumentException("O chassi não pode ser vazio ou nulo.");
            }

            if (veiculo.Chassi.Length != 5) // Supondo que o chassi tenha 5 caracteres
            {
                throw new ArgumentException("O chassi deve ter exatamente 5 caracteres.");
            }
        }
    }
}
