using Moq;
using ProjectInlog.Core.Entities.Enum;
using ProjectInlog.Core.Entities;
using ProjectInlog.Infrastructure.Repositories;

namespace GerenciamentoFrota.Tests
{
    public class AtualizarVeiculoTests
    {
        private readonly Mock<IVeiculoRepository> _mockRepository;
        private readonly IVeiculoRepository _veiculoRepository;

        public AtualizarVeiculoTests()
        {
            _mockRepository = new Mock<IVeiculoRepository>();
            _veiculoRepository = _mockRepository.Object;
        }

        [Fact]
        public void AtualizarVeiculo_ValidData_ShouldUpdateVeiculo()
        {

            // Arrange
            var veiculoExistente = new Veiculo();
            veiculoExistente.AtualizarChassi("ABC12");
            veiculoExistente.AtualizarCor("Branca");
            veiculoExistente.AlterarTipo(TipoVeiculo.Caminhao);
                        
            var veiculoAtualizado = new Veiculo();
            veiculoAtualizado.AtualizarChassi("ABC12");  // Preserva o chassi original para garantir que estamos atualizando o correto
            veiculoAtualizado.AtualizarCor("Preta");
            veiculoAtualizado.AlterarTipo(TipoVeiculo.Caminhao);

            // Configurando o mock para simular a busca do veículo existente
            _mockRepository.Setup(r => r.ObterVeiculoPorChassi("ABC12")).Returns(veiculoExistente);

            // Act
            veiculoExistente.AtualizarCor("Preta");
            _veiculoRepository.AtualizarVeiculo(veiculoExistente);

            // Assert
            Assert.Equal("Preta", veiculoExistente.Cor);
            Assert.Equal(TipoVeiculo.Caminhao, veiculoExistente.Tipo);

            // Verifica se o método de atualização foi chamado no repositório
            _mockRepository.Verify(r => r.AtualizarVeiculo(It.Is<Veiculo>(v => v.Chassi == "ABC12")), Times.Once);
        }

    }
}
