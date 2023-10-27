using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RegistroEmpleados.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PuestosController : ControllerBase
    {
        private readonly Context _context;

        public PuestosController(Context context)
        {
            _context = context;
        }

        public bool Existe(int PuestoId)
        {
            return (_context.Puestos?.Any(p => p.PuestoId == PuestoId)).GetValueOrDefault();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Puestos>>> Obtener()
        {
            if(_context.Puestos == null)
            {
                return NotFound();
            }
            else
            {
                return await _context.Puestos.ToListAsync();
            }
        }

        [HttpGet("{PuestoId}")]
        public async Task<ActionResult<Puestos>> ObtenerPuestos(int PuestoId)
        {
            if(_context.Puestos == null)
            {
                return NotFound();
            }

            var puesto = await _context.Puestos.FindAsync(PuestoId);

            if(puesto == null)
            {
                return NotFound();
            }
            return puesto;
        }

        [HttpPost]
        public async Task<ActionResult<Puestos>> PostPuestos(Puestos puestos)
        {
            if(!Existe(puestos.PuestoId))
            {
                _context.Puestos.Add(puestos);
            }
            else
            {
                _context.Puestos.Update(puestos);
            }

            await _context.SaveChangesAsync();
            return Ok(puestos);
        }

        [HttpDelete("{PuestoId}")]
        public async Task<IActionResult> Eliminar(int PuestoId)
        {
            if(_context.Puestos == null)
            {
                return NotFound();
            }

            var puesto = await _context.Puestos.FindAsync(PuestoId);

            if(puesto == null)
            {
                return NotFound();
            }

            _context.Puestos.Remove(puesto);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}