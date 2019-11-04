using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ImoveisWebApiCore.Models;

namespace ImoveisWebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProprietárioController : ControllerBase
    {
        private readonly ImoveisContext _context;

        public ProprietárioController(ImoveisContext context)
        {
            _context = context;
        }

        // GET: api/Proprietário
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proprietário>>> GetProprietários()
        {
            return await _context.Proprietários.ToListAsync();
        }

        // GET: api/Proprietário/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proprietário>> GetProprietário(int id)
        {
            var proprietário = await _context.Proprietários.FindAsync(id);

            if (proprietário == null)
            {
                return NotFound();
            }

            return proprietário;
        }

        // PUT: api/Proprietário/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProprietário(int id, Proprietário proprietário)
        {
            if (id != proprietário.Id)
            {
                return BadRequest();
            }

            _context.Entry(proprietário).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProprietárioExists(id))
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

        // POST: api/Proprietário
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Proprietário>> PostProprietário(Proprietário proprietário)
        {
            _context.Proprietários.Add(proprietário);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProprietário), new { id = proprietário.Id }, proprietário);
        }

        // DELETE: api/Proprietário/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Proprietário>> DeleteProprietário(int id)
        {
            var proprietário = await _context.Proprietários.FindAsync(id);
            if (proprietário == null)
            {
                return NotFound();
            }

            _context.Proprietários.Remove(proprietário);
            await _context.SaveChangesAsync();

            return proprietário;
        }

        private bool ProprietárioExists(int id)
        {
            return _context.Proprietários.Any(e => e.Id == id);
        }
    }
}
