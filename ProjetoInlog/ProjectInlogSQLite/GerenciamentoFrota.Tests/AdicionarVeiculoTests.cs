using Xunit;
using ProjectInlog; // Namespace do seu projeto principal, ajuste conforme necessário
using ProjectInlog.Core.Entities;
using ProjectInlog.Core.Services;
using ProjectInlog.Infrastructure.Repositories;
using Moq;
using ProjectInlog.Core.Entities.Enum;
using ProjectInlog.Infraestrutura.Data;

namespace GerenciamentoFrota.Tests
{
    public class AdicionarVeiculoTests
    {
        // Configurando o mock do repositório
        private readonly Mock<IVeiculoRepository> _mockRepository;
        private readonly IVeiculoRepository _veiculoRepository;
        public AdicionarVeiculoTests()
        {
            _mockRepository = new Mock<IVeiculoRepository>();
            _veiculoRepository = _mockRepository.Object;
        }
    
    [Fact]
        public void RegistrarVeiculo_ValidChassi_ShouldAddVeiculo()
        {
            // Arrange
            var veiculo = new Veiculo();
            veiculo.AtualizarChassi("ABC12");
            veiculo.AtualizarCor("Branca");
            veiculo.AlterarTipo(TipoVeiculo.Caminhao);

            // Act
            _veiculoRepository.AdicionarVeiculo(veiculo);

            // Assert
            _mockRepository.Verify(r => r.AdicionarVeiculo(It.Is<Veiculo>(v => v.Chassi == veiculo.Chassi)), Times.Once);
        }

        [Fact]
        public void RegistrarVeiculo_InvalidChassi_ShouldThrowException()
        {
            // Arrange
            var veiculo = new Veiculo();

            veiculo.AtualizarChassi(string.Empty);
            veiculo.AtualizarCor("Branca");
            veiculo.AlterarTipo(TipoVeiculo.Caminhao);

            // Act & Assert
            _mockRepository.Setup(r => r.AdicionarVeiculo(It.IsAny<Veiculo>()))
            .Throws(new ArgumentException("Chassi não pode ser vazio."));

        }
    }
}
