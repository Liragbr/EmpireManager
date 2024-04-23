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
    public class PedidoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PedidoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("Adicionar")]
        public async Task<ActionResult<Pedido>> Adicionar(Pedido pedidoTela)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Pedidos.Add(pedidoTela); // Corrigido para DbSet correto
            await _context.SaveChangesAsync();
            return Ok(pedidoTela);
        }

        [HttpGet("ListarVendas")]
        public async Task<ActionResult<IEnumerable<Pedido>>> ListarVendas()
        {
            var pedidos = await _context.Pedidos.ToListAsync(); // Corrigido para DbSet correto
            return Ok(pedidos);
        }
    }
}
