using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RegistroEmpleados.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProfesionesController : ControllerBase
    {
        private readonly Context _context;

        public ProfesionesController(Context context)
        {
            _context = context;
        }

        public bool Existe(int ProfesionId)
        {
            return (_context.Profesiones?.Any(p => p.ProfesionId == ProfesionId)).GetValueOrDefault();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profesiones>>> Obtener()
        {
            if(_context.Profesiones == null)
            {
                return NotFound();
            }
            else
            {
                return await _context.Profesiones.ToListAsync();
            }
        }

        [HttpGet("{ProfesionId}")]
        public async Task<ActionResult<Profesiones>> ObtenerProfesion(int ProfesionId)
        {
            if(_context.Profesiones == null)
            {
                return NotFound();
            }

            var profesion = await _context.Profesiones.FindAsync(ProfesionId);

            if(profesion == null)
            {
                return NotFound();
            }
            return profesion;
        }

        [HttpPost]
        public async Task<ActionResult<Empleados>> PostProfesion(Profesiones profesiones)
        {
            if(!Existe(profesiones.ProfesionId))
            {
                _context.Profesiones.Add(profesiones);
            }
            else
            {
                _context.Profesiones.Update(profesiones);
            }

            await _context.SaveChangesAsync();
            return Ok(profesiones);
        }

        [HttpDelete("{ProfesionId}")]
        public async Task<IActionResult> Eliminar(int ProfesionId)
        {
            if(_context.Profesiones == null)
            {
                return NotFound();
            }

            var profesion = await _context.Profesiones.FindAsync(ProfesionId);

            if(profesion == null)
            {
                return NotFound();
            }

            _context.Profesiones.Remove(profesion);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}