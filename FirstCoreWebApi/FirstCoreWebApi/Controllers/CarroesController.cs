﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstCoreWebApi.Models;

namespace FirstCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroesController : ControllerBase
    {
        private readonly FirstCodeContext _context;

        public CarroesController(FirstCodeContext context)
        {
            _context = context;
        }

        // GET: api/Carroes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Carro>>> GetCarro()
        {
            return await _context.Carro.ToListAsync();
        }

        // GET: api/Carroes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Carro>> GetCarro(int id)
        {
            var carro = await _context.Carro.FindAsync(id);

            if (carro == null)
            {
                return NotFound();
            }

            return carro;
        }

        // PUT: api/Carroes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarro(int id, Carro carro)
        {
            if (id != carro.Id)
            {
                return BadRequest();
            }

            _context.Entry(carro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarroExists(id))
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

        // POST: api/Carroes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Carro>> PostCarro(Carro carro)
        {
            _context.Carro.Add(carro);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCarro), new { id = carro.Id }, carro);
        }

        // DELETE: api/Carroes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Carro>> DeleteCarro(int id)
        {
            var carro = await _context.Carro.FindAsync(id);
            if (carro == null)
            {
                return NotFound();
            }

            _context.Carro.Remove(carro);
            await _context.SaveChangesAsync();

            return carro;
        }

        private bool CarroExists(int id)
        {
            return _context.Carro.Any(e => e.Id == id);
        }
    }
}
