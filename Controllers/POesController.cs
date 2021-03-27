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
    public class POesController : ControllerBase
    {
        private readonly DBContext _context;

        public POesController(DBContext context)
        {
            _context = context;
        }

        // GET: api/POes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PO>>> GetPOs( int id)
        {
            return await _context.POs.Where(s => s.ID == id).ToListAsync();

        }

        // GET: api/POes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PO>> GetPO(int id)
        {


            var pO = await _context.POs
               .Include(i => i.LO)
               .Where(i => i.ID == id)
               .FirstOrDefaultAsync();

            if (pO == null)
            {
                return NotFound();
            }

            return pO;
        }

        // PUT: api/POes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPO(string id, PO pO)
        {
            if (id != pO.POID)
            {
                return BadRequest();
            }

            _context.Entry(pO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!POExists(id))
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

        // POST: api/POes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PO>> PostPO(PO pO)
        {
            _context.POs.Add(pO);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (POExists(pO.POID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPO", new { id = pO.POID }, pO);
        }

        // DELETE: api/POes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePO(string id)
        {
            var pO = await _context.POs.FindAsync(id);
            if (pO == null)
            {
                return NotFound();
            }

            _context.POs.Remove(pO);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool POExists(string id)
        {
            return _context.POs.Any(e => e.POID == id);
        }
    }
}
