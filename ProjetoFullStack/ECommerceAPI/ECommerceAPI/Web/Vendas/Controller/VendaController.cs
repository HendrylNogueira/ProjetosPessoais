using ECommerceAPI.Domain.Vendas.Entities;
using ECommerceAPI.Infrastructure.Vendas.Data.Repositories;
using ECommerceAPI.Application.Vendas.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommerceAPI.Infrastructure.Produtos.Data;

namespace ECommerceAPI.Web.Vendas.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendaController : ControllerBase
    {
        private readonly IVendasRepository _vendasRepository;
        private readonly ApplicationDbContext _context;

        public VendaController(IVendasRepository vendasRepository, ApplicationDbContext context)
        {
            _vendasRepository = vendasRepository;
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Venda>>> GetVendas()
        {
            var vendas = await _vendasRepository.GetAllVendasAsync();
            return Ok(vendas);
        }

        [HttpGet("{id}")]
        public IActionResult ObterVendaPorId(int id)
        {
            return Ok(new { message = "Endpoint ainda não implementado" });
        }


        [HttpPost]
        public async Task<ActionResult> CreateVenda([FromBody] VendaDto vendaDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var venda = new Venda
            {
                ClienteId = vendaDto.IdClienteDto.IdCliente,
                VendaProdutos = vendaDto.VendaProdutos
                .Select(vp => new VendaProduto
                {
                    ProdutoId = vp.ProdutoId,
                    Quantidade = vp.Quantidade,
                    PrecoUnitario = vp.PrecoUnitario
                }).ToList()

            };


            await _vendasRepository.AddVendaAsync(venda);
            // Buscar novamente a venda para incluir os produtos na resposta
            var vendaCompleta = await _context.Vendas
                .Include(v => v.VendaProdutos)
                .ThenInclude(vp => vp.Produto) // Carregar os detalhes dos produtos
                .FirstOrDefaultAsync(v => v.Id == venda.Id);
            return CreatedAtAction(nameof(ObterVendaPorId), new { id = venda.Id }, venda);
        }


    }
}
