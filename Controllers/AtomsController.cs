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
    public class AtomsController : ControllerBase
    {
        private readonly AtomlistContext _context;

        public AtomsController(AtomlistContext context)
        {
            _context = context;
        }

        // GET: api/Atoms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Atom>>> GetAtoms()
        {
            return await _context.Atoms.ToListAsync();
        }

        // GET: api/Atoms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Atom>> GetAtom(int id)
        {
            var atom = await _context.Atoms.FindAsync(id);

            if (atom == null)
            {
                return NotFound();
            }

            return atom;
        }

        // PUT: api/Atoms/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAtom(int id, Atom atom)
        {
            if (id != atom.Id)
            {
                return BadRequest();
            }

            _context.Entry(atom).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AtomExists(id))
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

        // POST: api/Atoms
        [HttpPost]
        public async Task<ActionResult<Atom>> PostAtom(Atom atom)
        {
            _context.Atoms.Add(atom);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAtom", new { id = atom.Id }, atom);
        }

        // DELETE: api/Atoms/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Atom>> DeleteAtom(int id)
        {
            var atom = await _context.Atoms.FindAsync(id);
            if (atom == null)
            {
                return NotFound();
            }

            _context.Atoms.Remove(atom);
            await _context.SaveChangesAsync();

            return atom;
        }

        private bool AtomExists(int id)
        {
            return _context.Atoms.Any(e => e.Id == id);
        }
    }
}
