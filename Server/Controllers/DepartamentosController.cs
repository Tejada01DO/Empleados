using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RegistroEmpleados.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DepartamentosController : ControllerBase
    {
        private readonly Context _context;

        public DepartamentosController(Context context)
        {
            _context = context;
        }

        public bool Existe(int DepartamentoId)
        {
            return (_context.Departamentos?.Any(d => d.DepartamentoId == DepartamentoId)).GetValueOrDefault();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Departamentos>>> Obtener()
        {
            if(_context.Departamentos == null)
            {
                return NotFound();
            }
            else
            {
                return await _context.Departamentos.ToListAsync();
            }
        }

        [HttpGet("{DepartamentoId}")]
        public async Task<ActionResult<Departamentos>> ObtenerDepartamento(int DepartamentoId)
        {
            if(_context.Departamentos == null)
            {
                return NotFound();
            }

            var departamento = await _context.Departamentos.FindAsync(DepartamentoId);

            if(departamento == null)
            {
                return NotFound();
            }
            return departamento;
        }

        [HttpPost]
        public async Task<ActionResult<Departamentos>> PostDepartamentos(Departamentos departamentos)
        {
            if(!Existe(departamentos.DepartamentoId))
            {
                _context.Departamentos.Add(departamentos);
            }
            else
            {
                _context.Departamentos.Update(departamentos);
            }

            await _context.SaveChangesAsync();
            return Ok(departamentos);
        }

        [HttpDelete("{DepartamentoId}")]
        public async Task<IActionResult> Eliminar(int DepartamentoId)
        {
            if(_context.Departamentos == null)
            {
                return NotFound();
            }

            var departamento = await _context.Departamentos.FindAsync(DepartamentoId);

            if(departamento == null)
            {
                return NotFound();
            }

            _context.Departamentos.Remove(departamento);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}