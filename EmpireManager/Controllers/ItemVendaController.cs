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
    public class ItemVendaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ItemVendaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("Inserir")]
        public async Task<ActionResult<ItemVenda>> Inserir(ItemVenda itemVendaTela)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ItemVendas.Add(itemVendaTela);
            await _context.SaveChangesAsync();
            return Ok(itemVendaTela);
        }

        [HttpDelete("Excluir")]
        public async Task<ActionResult> Excluir(int idProduto, int idVenda)
        {
            var itemVenda = await _context.ItemVendas.FirstOrDefaultAsync(iv => iv.ProdutoId == idProduto && iv.VendaID == idVenda);
            if (itemVenda == null)
            {
                return NotFound();
            }

            _context.ItemVendas.Remove(itemVenda);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
