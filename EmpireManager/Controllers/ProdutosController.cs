using EmpireManager.Data;
using EmpireManager.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmpireManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProdutoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("Adicionar")]
        public async Task<ActionResult<Produtos>> Adicionar(Produtos produtoTela)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Produtos.Add(produtoTela);
            await _context.SaveChangesAsync();
            return Ok(produtoTela);
        }

        [HttpPut("Alterar")]
        public async Task<ActionResult<Produtos>> Alterar(Produtos produtoTela)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var produto = await _context.Produtos.FindAsync(produtoTela.Id);
            if (produto == null)
            {
                return NotFound();
            }

            produto.Name = produtoTela.Name;
            produto.Descricao = produtoTela.Descricao;
            produto.QuantidadeEstoque = produtoTela.QuantidadeEstoque;
            produto.UnidadeMedida = produtoTela.UnidadeMedida;
            produto.PrecoUnitario = produtoTela.PrecoUnitario;
            produto.ImgProduto = produtoTela.ImgProduto;

            await _context.SaveChangesAsync();
            return Ok(produto);
        }

        [HttpDelete("Excluir/{id}")]
        public async Task<ActionResult> Excluir(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }

            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet("PesquisarPorID/{id}")]
        public async Task<ActionResult<Produtos>> PesquisarPorID(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);
        }

        [HttpGet("ListarTodos")]
        public async Task<ActionResult<IEnumerable<Produtos>>> ListarTodos()
        {
            return await _context.Produtos.ToListAsync();
        }
    }
}
