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
    public class APIChampionshipCommandsController : ControllerBase
    {
        private readonly FootballContext _context;

        public APIChampionshipCommandsController(FootballContext context)
        {
            _context = context;
        }

        // GET: api/APIChampionshipCommands
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionshipCommand>>> GetChampionshipCommands()
        {
            return await _context.ChampionshipCommands.ToListAsync();
        }

        // GET: api/APIChampionshipCommands/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionshipCommand>> GetChampionshipCommand(int id)
        {
            var championshipCommand = await _context.ChampionshipCommands.FindAsync(id);

            if (championshipCommand == null)
            {
                return NotFound();
            }

            return championshipCommand;
        }

        // PUT: api/APIChampionshipCommands/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionshipCommand(int id, ChampionshipCommand championshipCommand)
        {
            if (id != championshipCommand.ChampionshipCommandID)
            {
                return BadRequest();
            }

            _context.Entry(championshipCommand).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionshipCommandExists(id))
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

        // POST: api/APIChampionshipCommands
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ChampionshipCommand>> PostChampionshipCommand(ChampionshipCommand championshipCommand)
        {
            _context.ChampionshipCommands.Add(championshipCommand);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChampionshipCommand", new { id = championshipCommand.ChampionshipCommandID }, championshipCommand);
        }

        // DELETE: api/APIChampionshipCommands/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ChampionshipCommand>> DeleteChampionshipCommand(int id)
        {
            var championshipCommand = await _context.ChampionshipCommands.FindAsync(id);
            if (championshipCommand == null)
            {
                return NotFound();
            }

            _context.ChampionshipCommands.Remove(championshipCommand);
            await _context.SaveChangesAsync();

            return championshipCommand;
        }

        private bool ChampionshipCommandExists(int id)
        {
            return _context.ChampionshipCommands.Any(e => e.ChampionshipCommandID == id);
        }
    }
}
