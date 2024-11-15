using Microsoft.EntityFrameworkCore;
using ProjectInlog.Core.Entities;
using ProjectInlog.Infraestrutura.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectInlog.Infrastructure.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly ApplicationDbContext _context;

        public VeiculoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
        }

        public Veiculo ObterVeiculoPorChassi(string chassi)
        {
            return _context.Veiculos.FirstOrDefault(v => v.Chassi == chassi);
        }

        public IEnumerable<Veiculo> ObterTodosVeiculos()
        {
            return _context.Veiculos.ToList();
        }

        public void AtualizarVeiculo(Veiculo veiculo)
        {
            _context.Veiculos.Update(veiculo);
            _context.SaveChanges();
        }

        public void RemoverVeiculo(string chassi)
        {
            var veiculo = _context.Veiculos.FirstOrDefault(v => v.Chassi == chassi);
            if (veiculo != null)
            {
                _context.Veiculos.Remove(veiculo);
                _context.SaveChanges();
            }
        }
    }
}
