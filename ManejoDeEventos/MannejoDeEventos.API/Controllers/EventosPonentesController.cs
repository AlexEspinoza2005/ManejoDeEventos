using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ManejoDeEventos;

namespace MannejoDeEventos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosPonentesController : ControllerBase
    {
        private readonly AppHDbContext _context;

        public EventosPonentesController(AppHDbContext context)
        {
            _context = context;
        }

        // GET: api/EventosPonentes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventoPonente>>> GetEventoPonente()
        {
            var datos = await _context.EventoSPonenteS
                .Include(ep => ep.Evento)
                .Include(ep => ep.Ponente)
                .ToListAsync();

            return datos;
        }


        // GET: api/EventosPonentes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventoPonente>> GetEventoPonente(int id)
        {
            var eventoPonente = await _context.EventoSPonenteS.FindAsync(id);

            if (eventoPonente == null)
            {
                return NotFound();
            }

            return eventoPonente;
        }

        // PUT: api/EventosPonentes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventoPonente(int id, EventoPonente eventoPonente)
        {
            if (id != eventoPonente.IdEventoPonente)
            {
                return BadRequest();
            }

            _context.Entry(eventoPonente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventoPonenteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EventosPonentes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EventoPonente>> PostEventoPonente(EventoPonente eventoPonente)
        {
            _context.EventoSPonenteS.Add(eventoPonente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEventoPonente", new { id = eventoPonente.IdEventoPonente }, eventoPonente);
        }

        // DELETE: api/EventosPonentes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventoPonente(int id)
        {
            var eventoPonente = await _context.EventoSPonenteS.FindAsync(id);
            if (eventoPonente == null)
            {
                return NotFound();
            }

            _context.EventoSPonenteS.Remove(eventoPonente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EventoPonenteExists(int id)
        {
            return _context.EventoSPonenteS.Any(e => e.IdEventoPonente == id);
        }
    }
}
