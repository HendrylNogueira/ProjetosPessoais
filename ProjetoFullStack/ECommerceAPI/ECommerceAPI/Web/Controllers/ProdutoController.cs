using ECommerceAPI.Application.Interfaces;
using ECommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            var produtos = await _produtoRepository.GetAllProdutosAsync();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProduto(int id)
        {
            var produto = await _produtoRepository.GetProdutoByIdAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        [HttpPost]
        public async Task<ActionResult> CreateProduto(Produto produto)
        {
            await _produtoRepository.AddProdutoAsync(produto);
            return CreatedAtAction(nameof(GetProduto), new { id = produto.Id }, produto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarNomeProduto(int id, [FromBody] AtualizarProdutoDto dto)
        {

            if (dto == null || (string.IsNullOrWhiteSpace(dto.Nome) && string.IsNullOrWhiteSpace(dto.Descricao)))
            {
                return BadRequest("Nome e/ou descrição não podem estar vazios.");
            }

            var produto = await _produtoRepository.GetProdutoByIdAsync(id);

            if (produto == null)
            {
                return NotFound("Produto não encontrado.");
            }

            if (!string.IsNullOrWhiteSpace(dto.Nome))
            {
                produto.Nome = dto.Nome;
            }

            if (!string.IsNullOrWhiteSpace(dto.Descricao))
            {
                produto.Descricao = dto.Descricao;
            }

            if (!float.IsNaN(dto.Preco))
            {
                produto.Preco = dto.Preco;
            }

            if (!string.IsNullOrWhiteSpace(dto.Categoria))
            {
                produto.Categoria = dto.Categoria;
            }

            await _produtoRepository.UpdateProdutoAsync(produto);

            return Ok(produto);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduto(int id)
        {
            await _produtoRepository.DeleteProdutoAsync(id);
            return NoContent();
        }

    }
}
