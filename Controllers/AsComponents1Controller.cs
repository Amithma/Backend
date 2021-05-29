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
    public class AsComponents1Controller : ControllerBase
    {
        private readonly DBContext _context;

        public AsComponents1Controller(DBContext context)
        {
            _context = context;
        }

        // GET: api/AsComponents1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AsComponent>>> GetAsComponents()
        {
            return await _context.AsComponents.ToListAsync();
        }

        // GET: api/AsComponents1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AsComponent>> GetAsComponent(int id)
        {
            var asComponent = await _context.AsComponents.FindAsync(id);

            if (asComponent == null)
            {
                return NotFound();
            }

            return asComponent;
        }

        // PUT: api/AsComponents1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsComponent(int id, AsComponent asComponent)
        {
            if (id != asComponent.AsID)
            {
                return BadRequest();
            }

            _context.Entry(asComponent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AsComponentExists(id))
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

        // POST: api/AsComponents1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AsComponent>> PostAsComponent(AsComponent asComponent)
        {
            _context.AsComponents.Add(asComponent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAsComponent", new { id = asComponent.AsID }, asComponent);
        }

        // DELETE: api/AsComponents1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsComponent(int id)
        {
            var asComponent = await _context.AsComponents.FindAsync(id);
            if (asComponent == null)
            {
                return NotFound();
            }

            _context.AsComponents.Remove(asComponent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AsComponentExists(int id)
        {
            return _context.AsComponents.Any(e => e.AsID == id);
        }
    }
}
