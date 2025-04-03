using ECommerceAPI.Application.Clientes.Interfaces;
using ECommerceAPI.Domain.Clientes.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Web.Clientes.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;


        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            var clientes = await _clienteRepository.GetAllClientesAsync();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            var cliente = await _clienteRepository.GetClienteByIdAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpPost]
        public async Task<ActionResult> CreateProduto(Cliente cliente)
        {
            await _clienteRepository.AddClienteAsync(cliente);
            return CreatedAtAction(nameof(GetCliente), new { id = cliente.Id }, cliente);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarTelefoneCliente(int id, [FromBody] AtualizarClienteDto dto)
        {

            if (dto == null || string.IsNullOrWhiteSpace(dto.Telefone))
            {
                return BadRequest("Telefone não pode estar vazio.");
            }

            var cliente = await _clienteRepository.GetClienteByIdAsync(id);

            if (cliente == null)
            {
                return NotFound("Cliente não encontrado.");
            }

            if (!string.IsNullOrWhiteSpace(dto.Telefone))
            {
                cliente.Telefone = dto.Telefone;
            }

            await _clienteRepository.UpdateClienteAsync(cliente);

            return Ok(cliente);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCliente(int id)
        {
            await _clienteRepository.DeleteClienteAsync(id);
            return NoContent();
        }

    }
}
