using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AuthDemo.Data;
using AuthDemo.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;

namespace AuthDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LOes1Controller : ControllerBase
    {
        private readonly DBContext _context;

        public LOes1Controller(DBContext context)
        {
            _context = context;
        }

        // GET: api/LOes1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LO>>> GetLOs()
        {
            return await _context.LOs.ToListAsync();
        }

        // GET: api/LOes1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LO>> GetLO(int id)
        {
            var lO = await _context.LOs.FindAsync(id);

            if (lO == null)
            {
                return NotFound();
            }

            return lO;
        }

        // PUT: api/LOes1/5
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

        // POST: api/LOes1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LO>> PostLO(LO lO)
        {
            _context.LOs.Add(lO);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLO", new { id = lO.ID }, lO);
        }


        [HttpPatch("{id}")]
        public async Task<ActionResult> Patch(int id, [FromBody] JsonPatchDocument<LO> patchLO)
        {
            if (patchLO == null)
            {
                return BadRequest();
            }

            var lo = await _context.LOs.FirstOrDefaultAsync(x => x.ID == id);

            if (lo == null)
            {
                return NotFound();
            }

            patchLO.ApplyTo(lo, ModelState);

            var isValid = TryValidateModel(lo);

            if (!isValid)
            {
                return BadRequest(ModelState);
            }

            await _context.SaveChangesAsync();

            return NoContent();
        }






        // DELETE: api/LOes1/5
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
