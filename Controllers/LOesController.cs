using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AuthDemo.Data;
using AuthDemo.Models;

namespace AuthDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LOesController : ControllerBase
    {
        private readonly DBContext _context;

        public LOesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/LOes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LO>>> GetLOs(string id)
        {

            return await _context.LOs.Where(s => s.ModuleId == id).ToListAsync();

        }

        // GET: api/LOes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LO>> GetLO(string id)
        {

            var lO = await _context.LOs
               .Include(i => i.Module)
               .Where(i => i.ModuleId == id)
               .FirstOrDefaultAsync();

            if (lO == null)
            {
                return NotFound();
            }

            return lO;
        }

        // PUT: api/LOes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLO(int id, LO lO)
        {
            if (id != lO.ID)
            {
                return BadRequest();
            }

            _context.Entry(lO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LOExists(id))
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

        // POST: api/LOes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LO>> PostLO(LO lO)
        {
            _context.LOs.Add(lO);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLO", new { id = lO.ID }, lO);
        }

        // DELETE: api/LOes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLO(int id)
        {
            var lO = await _context.LOs.FindAsync(id);
            if (lO == null)
            {
                return NotFound();
            }

            _context.LOs.Remove(lO);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LOExists(int id)
        {
            return _context.LOs.Any(e => e.ID == id);
        }
    }
}
