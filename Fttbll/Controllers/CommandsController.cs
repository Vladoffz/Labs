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
    public class CommandsController : Controller
    {
        private readonly FootballContext _context;

        public CommandsController(FootballContext context)
        {
            _context = context;
        }

        // GET: Commands
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            ViewData["NameSort"] = String.IsNullOrEmpty(sortOrder) ? "Name" : "";
            ViewData["CurrentFilter"] = searchString;
            var commands = from c in _context.Commands
                select c;
            if (!String.IsNullOrEmpty(searchString))
            {
                commands = commands.Where(s => s.Name.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "Name":
                    commands = commands.OrderByDescending(c => c.Name);
                    break;
                case "Country":
                    commands = commands.OrderBy(c => c.Country);
                    break;
                case "Players":
                    commands = commands.OrderByDescending(c => c.Players);
                    break;
                case "PlayerID":
                    commands = commands.OrderByDescending(c => c.PlayerID);
                    break;
                default:
                    commands = commands.OrderBy(c => c.CommandID);
                    break;
            }
            return View(await commands.AsNoTracking().ToListAsync());
        }

        // GET: Commands/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var command = await _context.Commands
                .FirstOrDefaultAsync(m => m.CommandID == id);
            if (command == null)
            {
                return NotFound();
            }

            return View(command);
        }

        // GET: Commands/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Commands/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CommandID,PlayerID,Country,Name")] Command command)
        {
            if (ModelState.IsValid)
            {
                _context.Add(command);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(command);
        }

        // GET: Commands/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var command = await _context.Commands.FindAsync(id);
            if (command == null)
            {
                return NotFound();
            }
            return View(command);
        }

        // POST: Commands/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CommandID,PlayerID,Country,Name")] Command command)
        {
            if (id != command.CommandID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(command);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommandExists(command.CommandID))
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
            return View(command);
        }

        // GET: Commands/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var command = await _context.Commands
                .FirstOrDefaultAsync(m => m.CommandID == id);
            if (command == null)
            {
                return NotFound();
            }

            return View(command);
        }

        // POST: Commands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var command = await _context.Commands.FindAsync(id);
            _context.Commands.Remove(command);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommandExists(int id)
        {
            return _context.Commands.Any(e => e.CommandID == id);
        }
    }
}
