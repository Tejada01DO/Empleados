using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RegistroEmpleados.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EmpleadosController : ControllerBase
    {
        private readonly Context _context;

        public EmpleadosController(Context context)
        {
            _context = context;
        }

        public bool Existe(int EmpleadoId)
        {
            return (_context.Empleados?.Any(e => e.EmpleadoId == EmpleadoId)).GetValueOrDefault();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empleados>>> Obtener()
        {
            if(_context.Empleados == null)
            {
                return NotFound();
            }
            else
            {
                return await _context.Empleados.ToListAsync();
            }
        }

        [HttpGet("{EmpleadoId}")]
        public async Task<ActionResult<Empleados>> ObtenerEmpleado(int EmpleadoId)
        {
            if(_context.Empleados == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleados.FindAsync(EmpleadoId);

            if(empleado == null)
            {
                return NotFound();
            }
            return empleado;
        }

        [HttpPost]
        public async Task<ActionResult<Empleados>> PostEmpleado(Empleados empleados)
        {
            if(!Existe(empleados.EmpleadoId))
            {
                _context.Empleados.Add(empleados);
            }
            else
            {
                _context.Empleados.Update(empleados);
            }

            await _context.SaveChangesAsync();
            return Ok(empleados);
        }

        [HttpDelete("{EmpleadoId}")]
        public async Task<IActionResult> Eliminar(int EmpleadoId)
        {
            if(_context.Empleados == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleados.FindAsync(EmpleadoId);

            if(empleado == null)
            {
                return NotFound();
            }

            _context.Empleados.Remove(empleado);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}