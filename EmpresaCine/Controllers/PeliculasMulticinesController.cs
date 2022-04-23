#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmpresaCine.Models;

namespace EmpresaCine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasMulticinesController : ControllerBase
    {
        private readonly cineContext _context;

        public PeliculasMulticinesController(cineContext context)
        {
            _context = context;
        }

        // GET: api/PeliculasMulticines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PeliculasMulticine>>> GetPeliculasMulticines()
        {
            return await _context.PeliculasMulticines.ToListAsync();
        }

        // GET: api/PeliculasMulticines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PeliculasMulticine>> GetPeliculasMulticine(int id)
        {
            var peliculasMulticine = await _context.PeliculasMulticines.FindAsync(id);

            if (peliculasMulticine == null)
            {
                return NotFound();
            }

            return peliculasMulticine;
        }

        // PUT: api/PeliculasMulticines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeliculasMulticine(int id, PeliculasMulticine peliculasMulticine)
        {
            if (id != peliculasMulticine.IdPeliculasMulticine)
            {
                return BadRequest();
            }

            _context.Entry(peliculasMulticine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeliculasMulticineExists(id))
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

        // POST: api/PeliculasMulticines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PeliculasMulticine>> PostPeliculasMulticine(PeliculasMulticine peliculasMulticine)
        {
            _context.PeliculasMulticines.Add(peliculasMulticine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPeliculasMulticine", new { id = peliculasMulticine.IdPeliculasMulticine }, peliculasMulticine);
        }

        // DELETE: api/PeliculasMulticines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePeliculasMulticine(int id)
        {
            var peliculasMulticine = await _context.PeliculasMulticines.FindAsync(id);
            if (peliculasMulticine == null)
            {
                return NotFound();
            }

            _context.PeliculasMulticines.Remove(peliculasMulticine);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PeliculasMulticineExists(int id)
        {
            return _context.PeliculasMulticines.Any(e => e.IdPeliculasMulticine == id);
        }
    }
}
