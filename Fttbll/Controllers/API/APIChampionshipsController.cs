using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Fttbll.Data;
using Fttbll.Models;

namespace Fttbll.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIChampionshipsController : ControllerBase
    {
        private readonly FootballContext _context;

        public APIChampionshipsController(FootballContext context)
        {
            _context = context;
        }

        // GET: api/APIChampionships
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Championship>>> GetChampionships()
        {
            return await _context.Championships.ToListAsync();
        }

        // GET: api/APIChampionships/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Championship>> GetChampionship(int id)
        {
            var championship = await _context.Championships.FindAsync(id);

            if (championship == null)
            {
                return NotFound();
            }

            return championship;
        }

        // PUT: api/APIChampionships/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionship(int id, Championship championship)
        {
            if (id != championship.ID)
            {
                return BadRequest();
            }

            _context.Entry(championship).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionshipExists(id))
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

        // POST: api/APIChampionships
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Championship>> PostChampionship(Championship championship)
        {
            _context.Championships.Add(championship);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChampionship", new { id = championship.ID }, championship);
        }

        // DELETE: api/APIChampionships/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Championship>> DeleteChampionship(int id)
        {
            var championship = await _context.Championships.FindAsync(id);
            if (championship == null)
            {
                return NotFound();
            }

            _context.Championships.Remove(championship);
            await _context.SaveChangesAsync();

            return championship;
        }

        private bool ChampionshipExists(int id)
        {
            return _context.Championships.Any(e => e.ID == id);
        }
    }
}
