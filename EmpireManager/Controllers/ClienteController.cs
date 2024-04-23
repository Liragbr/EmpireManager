using EmpireManager.Data;
using EmpireManager.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpireManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ClienteController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("Adicionar")]
        public async Task<ActionResult<Cliente>> Adicionar(Cliente clienteTela)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Clientes.Add(clienteTela);
            await _context.SaveChangesAsync();
            return Ok(clienteTela);
        }

        [HttpDelete("Excluir/{id}")]
        public async Task<ActionResult> Excluir(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("Alterar")]
        public async Task<ActionResult<Cliente>> Alterar(Cliente clienteTela)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cliente = await _context.Clientes.FindAsync(clienteTela.Id);
            if (cliente == null)
            {
                return NotFound();
            }

            cliente.Name = clienteTela.Name;
            cliente.Cpf_cnpj = clienteTela.Cpf_cnpj;
            cliente.Email = clienteTela.Email;
            cliente.Telefone = clienteTela.Telefone;
            cliente.Endereco = clienteTela.Endereco;

            await _context.SaveChangesAsync();
            return Ok(cliente);
        }

        [HttpGet("PesquisarPorID/{id}")]
        public async Task<ActionResult<Cliente>> PesquisarPorID(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }

        [HttpGet("ListarTodos")]
        public async Task<ActionResult<IEnumerable<Cliente>>> ListarTodos()
        {
            return await _context.Clientes.ToListAsync();
        }

        [HttpGet("PesquisarPorNome")]
        public async Task<ActionResult<IEnumerable<Cliente>>> PesquisarPorNome(string nome)
        {
            var clientes = await _context.Clientes.Where(c => c.Name.Contains(nome)).ToListAsync();
            if (!clientes.Any())
            {
                return NotFound();
            }

            return Ok(clientes);
        }
    }
}
