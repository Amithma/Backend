using AuthDemo.Data;
using AuthDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsComponentsController : ControllerBase
    {
        private readonly DBContext _context;

        public AsComponentsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/AsComponents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AsComponent>>> GetAsComponents(string id)
        {
            return await _context.AsComponents.Where(s => s.ModuleId == id).ToListAsync();
        }

        // GET: api/AsComponents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AsComponent>> GetAsComponent(string id)
        {
            var asComponent = await _context.AsComponents
                .Include(i => i.Module)
                .Where(i => i.ModuleId == id)
                .FirstOrDefaultAsync();

            if (asComponent == null)
            {
                return NotFound();
            }

            return asComponent;
        }

        // PUT: api/AsComponents/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
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

        // POST: api/AsComponents
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AsComponent>> PostAsComponent(AsComponent asComponent)
        {
            _context.AsComponents.Add(asComponent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAsComponent", new { id = asComponent.AsID }, asComponent);
        }

        // DELETE: api/AsComponents/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AsComponent>> DeleteAsComponent(int id)
        {
            var asComponent = await _context.AsComponents.FindAsync(id);
            if (asComponent == null)
            {
                return NotFound();
            }

            _context.AsComponents.Remove(asComponent);
            await _context.SaveChangesAsync();

            return asComponent;
        }

        private bool AsComponentExists(int id)
        {
            return _context.AsComponents.Any(e => e.AsID == id);
        }
    }
}
