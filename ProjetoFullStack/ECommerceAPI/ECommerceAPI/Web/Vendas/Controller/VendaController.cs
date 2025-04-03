using ECommerceAPI.Domain.Vendas.Entities;
using ECommerceAPI.Infrastructure.Vendas.Data.Repositories;
using ECommerceAPI.Application.Vendas.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Web.Vendas.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendaController : ControllerBase
    {
        private readonly IVendasRepository _vendasRepository;
        public VendaController(IVendasRepository vendasRepository)
        {
            _vendasRepository = vendasRepository;
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
                Id = vendaDto.IdVenda, // Mantendo o ID
                ClienteId = vendaDto.IdClienteDto.IdCliente, // ✅ Pegando apenas o ID do cliente
            };


            await _vendasRepository.AddVendaAsync(venda);
            return CreatedAtAction(nameof(ObterVendaPorId), new { id = venda.Id }, venda);
        }


    }
}
