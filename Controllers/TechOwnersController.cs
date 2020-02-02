using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Atomlista.DataAccess;
using Atomlista.Models;

namespace Atomlista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechOwnersController : ControllerBase
    {
        private readonly AtomlistContext _context;

        public TechOwnersController(AtomlistContext context)
        {
            _context = context;
        }

        // GET: api/TechOwners
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TechOwner>>> GetTechOwners()
        {
            return await _context.TechOwners.ToListAsync();
        }

        // GET: api/TechOwners/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TechOwner>> GetTechOwner(int id)
        {
            var techOwner = await _context.TechOwners.FindAsync(id);

            if (techOwner == null)
            {
                return NotFound();
            }

            return techOwner;
        }

        // PUT: api/TechOwners/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTechOwner(int id, TechOwner techOwner)
        {
            if (id != techOwner.Id)
            {
                return BadRequest();
            }

            _context.Entry(techOwner).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TechOwnerExists(id))
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

        // POST: api/TechOwners
        [HttpPost]
        public async Task<ActionResult<TechOwner>> PostTechOwner(TechOwner techOwner)
        {
            _context.TechOwners.Add(techOwner);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTechOwner", new { id = techOwner.Id }, techOwner);
        }

        // DELETE: api/TechOwners/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TechOwner>> DeleteTechOwner(int id)
        {
            var techOwner = await _context.TechOwners.FindAsync(id);
            if (techOwner == null)
            {
                return NotFound();
            }

            _context.TechOwners.Remove(techOwner);
            await _context.SaveChangesAsync();

            return techOwner;
        }

        private bool TechOwnerExists(int id)
        {
            return _context.TechOwners.Any(e => e.Id == id);
        }
    }
}
