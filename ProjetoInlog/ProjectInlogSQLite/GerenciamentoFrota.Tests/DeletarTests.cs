using Moq;
using ProjectInlog.Core.Entities.Enum;
using ProjectInlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectInlog.Infrastructure.Repositories;

namespace GerenciamentoFrota.Tests
{
    public class DeletarTests
    {
        private readonly Mock<IVeiculoRepository> _mockRepository;
        private readonly IVeiculoRepository _veiculoRepository;

        public DeletarTests()
        {
            _mockRepository = new Mock<IVeiculoRepository>();
            _veiculoRepository = _mockRepository.Object;
        }
        [Fact]
        public void DeletarVeiculo_ValidChassi_ShouldRemoveVeiculo()
        {
            // Arrange
            var veiculoExistente = new Veiculo();
            veiculoExistente.AtualizarChassi("ABC12");
            veiculoExistente.AtualizarCor("Branca");
            veiculoExistente.AlterarTipo(TipoVeiculo.Caminhao);

            // Configurando o mock para simular a busca do veículo existente
            _mockRepository.Setup(r => r.ObterVeiculoPorChassi("ABC12")).Returns(veiculoExistente);

            // Act
            _veiculoRepository.RemoverVeiculo("ABC12");

            // Assert
            // Verifica se o método de exclusão foi chamado com o chassi correto
            _mockRepository.Verify(r => r.RemoverVeiculo(It.Is<string>(chassi => chassi == "ABC12")), Times.Once);

            // Verifica se o veículo foi de fato removido (usando a interface ou verificando algum estado)
            _mockRepository.Verify(r => r.ObterVeiculoPorChassi("ABC12"), Times.Never);
        }

    }
}
