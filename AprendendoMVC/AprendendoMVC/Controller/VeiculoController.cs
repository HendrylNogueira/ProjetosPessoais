using AprendendoMVC.Model;
using AprendendoMVC.View;

namespace AprendendoMVC.Controller
{
    public class VeiculoController
    {
        private List<Veiculo> veiculos = new List<Veiculo>();
        private VeiculoView view = new VeiculoView();

        public void AdicionarVeiculo()
        {
            Veiculo veiculo = view.ObterDadosVeiculo();
            veiculos.Add(veiculo);
            view.MostrarMensagem("Veículo adicionado com sucesso!");
        }

        public void ListarVeiculos()
        {
            view.MostrarListaVeiculos(veiculos);
        }
    }
}
