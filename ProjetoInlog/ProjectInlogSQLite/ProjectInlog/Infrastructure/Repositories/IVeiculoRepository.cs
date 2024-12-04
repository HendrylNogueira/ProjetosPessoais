using ProjectInlog.Core.Entities;

namespace ProjectInlog.Infrastructure.Repositories
{
    public interface IVeiculoRepository
    {
        void AdicionarVeiculo(Veiculo veiculo);
        Veiculo ObterVeiculoPorChassi(string chassi);
        IEnumerable<Veiculo> ObterTodosVeiculos();
        void AtualizarVeiculo(Veiculo veiculo);
        void RemoverVeiculo(string chassi);


    }
}
