using EmpireManager.Data;
using EmpireManager.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EmpireManager.Controllers
{
    public class FuncionarioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FuncionarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("Adicionar Funcionario")]
        public async Task<ActionResult<Funcionario>> Adicionar(Funcionario funcionarioTela)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Funcionarios.Add(funcionarioTela);
            await _context.SaveChangesAsync();
            return Ok(funcionarioTela);
        }

        [HttpDelete("Excluir Funcionario")]
        public async Task<ActionResult> Excluir(int idFuncionario)
        {
            var funcionario = await _context.Funcionarios.FindAsync(idFuncionario);
            if (funcionario == null)
            {
                return NotFound();
            }

            _context.Funcionarios.Remove(funcionario);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("Alterar Funcionario")]
        public async Task<ActionResult<Funcionario>> Alterar(Funcionario funcionarioTela)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var funcionario = await _context.Funcionarios.FindAsync(funcionarioTela.Id);
            if (funcionario == null)
            {
                return NotFound();
            }

            funcionario.Name = funcionarioTela.Name;
            funcionario.Cpf = funcionarioTela.Cpf;
            funcionario.Email = funcionarioTela.Email;
            funcionario.Cargo = funcionarioTela.Cargo;
            funcionario.Salario = funcionarioTela.Salario;
            funcionario.DataAdimissao = funcionarioTela.DataAdimissao;

            await _context.SaveChangesAsync();
            return Ok(funcionario);
        }

        [HttpGet("Pesquisar Funcionario por ID")]
        public async Task<ActionResult<Funcionario>> PesquisarPorID(int idFuncionario)
        {
            var funcionario = await _context.Funcionarios.FindAsync(idFuncionario);
            if (funcionario == null)
            {
                return NotFound();
            }

            return Ok(funcionario);
        }

        [HttpGet("Listar todos os Funcionario")]
        public async Task<ActionResult<IEnumerable<Funcionario>>> ListarTodos()
        {
            return await _context.Funcionarios.ToListAsync();
        }

        [HttpGet("Pesquisar por Nomes")]
        public async Task<ActionResult<IEnumerable<Funcionario>>> PesquisarPorNome(string name)
        {
            var funcionarios = await _context.Funcionarios.Where(f => f.Name.Contains(name)).ToListAsync();
            if (!funcionarios.Any())
            {
                return NotFound();
            }

            return Ok(funcionarios);
        }
    }
}
