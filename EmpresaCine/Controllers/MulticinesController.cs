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
    public class MulticinesController : ControllerBase
    {
        private readonly cineContext _context;

        public MulticinesController(cineContext context)
        {
            _context = context;
        }

        // GET: api/Multicines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Multicine>>> GetMulticines()
        {
            return await _context.Multicines.ToListAsync();
        }

        // GET: api/Multicines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Multicine>> GetMulticine(int id)
        {
            var multicine = await _context.Multicines.FindAsync(id);

            if (multicine == null)
            {
                return NotFound();
            }

            return multicine;
        }

        // PUT: api/Multicines/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMulticine(int id, Multicine multicine)
        {
            if (id != multicine.IdMulticine)
            {
                return BadRequest();
            }

            _context.Entry(multicine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MulticineExists(id))
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

        // POST: api/Multicines
        [HttpPost]
        public async Task<ActionResult<Multicine>> PostMulticine(Multicine multicine)
        {
            _context.Multicines.Add(multicine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMulticine", new { id = multicine.IdMulticine }, multicine);
        }

        // DELETE: api/Multicines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMulticine(int id)
        {
            var multicine = await _context.Multicines.FindAsync(id);
            if (multicine == null)
            {
                return NotFound();
            }

            _context.Multicines.Remove(multicine);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MulticineExists(int id)
        {
            return _context.Multicines.Any(e => e.IdMulticine == id);
        }
    }
}
