using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Fttbll.Data;
using Fttbll.Models;

namespace Fttbll.Controllers
{
    public class ChampionshipCommandsController : Controller
    {
        private readonly FootballContext _context;

        public ChampionshipCommandsController(FootballContext context)
        {
            _context = context;
        }

        // GET: ChampionshipCommands
        public async Task<IActionResult> Index()
        {
            var footballContext = _context.ChampionshipCommands.Include(c => c.Championship).Include(c => c.Command);
            return View(await footballContext.ToListAsync());
        }

        // GET: ChampionshipCommands/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var championshipCommand = await _context.ChampionshipCommands
                .Include(c => c.Championship)
                .Include(c => c.Command)
                .FirstOrDefaultAsync(m => m.ChampionshipCommandID == id);
            if (championshipCommand == null)
            {
                return NotFound();
            }

            return View(championshipCommand);
        }

        // GET: ChampionshipCommands/Create
        public IActionResult Create()
        {
            ViewData["ChampionshipID"] = new SelectList(_context.Championships, "ID", "ID");
            ViewData["CommandID"] = new SelectList(_context.Commands, "CommandID", "CommandID");
            return View();
        }

        // POST: ChampionshipCommands/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ChampionshipCommandID,ChampionshipID,CommandID")] ChampionshipCommand championshipCommand)
        {
            if (ModelState.IsValid)
            {
                _context.Add(championshipCommand);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ChampionshipID"] = new SelectList(_context.Championships, "ID", "ID", championshipCommand.ChampionshipID);
            ViewData["CommandID"] = new SelectList(_context.Commands, "CommandID", "CommandID", championshipCommand.CommandID);
            return View(championshipCommand);
        }

        // GET: ChampionshipCommands/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var championshipCommand = await _context.ChampionshipCommands.FindAsync(id);
            if (championshipCommand == null)
            {
                return NotFound();
            }
            ViewData["ChampionshipID"] = new SelectList(_context.Championships, "ID", "ID", championshipCommand.ChampionshipID);
            ViewData["CommandID"] = new SelectList(_context.Commands, "CommandID", "CommandID", championshipCommand.CommandID);
            return View(championshipCommand);
        }

        // POST: ChampionshipCommands/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ChampionshipCommandID,ChampionshipID,CommandID")] ChampionshipCommand championshipCommand)
        {
            if (id != championshipCommand.ChampionshipCommandID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(championshipCommand);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChampionshipCommandExists(championshipCommand.ChampionshipCommandID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ChampionshipID"] = new SelectList(_context.Championships, "ID", "ID", championshipCommand.ChampionshipID);
            ViewData["CommandID"] = new SelectList(_context.Commands, "CommandID", "CommandID", championshipCommand.CommandID);
            return View(championshipCommand);
        }

        // GET: ChampionshipCommands/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var championshipCommand = await _context.ChampionshipCommands
                .Include(c => c.Championship)
                .Include(c => c.Command)
                .FirstOrDefaultAsync(m => m.ChampionshipCommandID == id);
            if (championshipCommand == null)
            {
                return NotFound();
            }

            return View(championshipCommand);
        }

        // POST: ChampionshipCommands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var championshipCommand = await _context.ChampionshipCommands.FindAsync(id);
            _context.ChampionshipCommands.Remove(championshipCommand);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChampionshipCommandExists(int id)
        {
            return _context.ChampionshipCommands.Any(e => e.ChampionshipCommandID == id);
        }
    }
}
