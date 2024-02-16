using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoBancoDados.Models;

namespace ProjetoBancoDados.Controllers
{
    public class PacotesController : Controller
    {
        private readonly Contexto _context;

        public PacotesController(Contexto context)
        {
            _context = context;
        }

        // GET: Pacotes
        public async Task<IActionResult> Index()
        {
              return _context.Pacotes != null ? 
                          View(await _context.Pacotes.ToListAsync()) :
                          Problem("Entity set 'Contexto.Pacotes'  is null.");
        }

        // GET: Pacotes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pacotes == null)
            {
                return NotFound();
            }

            var pacotes = await _context.Pacotes
                .FirstOrDefaultAsync(m => m.PacotesId == id);
            if (pacotes == null)
            {
                return NotFound();
            }

            return View(pacotes);
        }

        // GET: Pacotes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pacotes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PacotesId,PacotesNome")] Pacotes pacotes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pacotes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pacotes);
        }

        // GET: Pacotes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pacotes == null)
            {
                return NotFound();
            }

            var pacotes = await _context.Pacotes.FindAsync(id);
            if (pacotes == null)
            {
                return NotFound();
            }
            return View(pacotes);
        }

        // POST: Pacotes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PacotesId,PacotesNome")] Pacotes pacotes)
        {
            if (id != pacotes.PacotesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pacotes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacotesExists(pacotes.PacotesId))
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
            return View(pacotes);
        }

        // GET: Pacotes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pacotes == null)
            {
                return NotFound();
            }

            var pacotes = await _context.Pacotes
                .FirstOrDefaultAsync(m => m.PacotesId == id);
            if (pacotes == null)
            {
                return NotFound();
            }

            return View(pacotes);
        }

        // POST: Pacotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pacotes == null)
            {
                return Problem("Entity set 'Contexto.Pacotes'  is null.");
            }
            var pacotes = await _context.Pacotes.FindAsync(id);
            if (pacotes != null)
            {
                _context.Pacotes.Remove(pacotes);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PacotesExists(int id)
        {
          return (_context.Pacotes?.Any(e => e.PacotesId == id)).GetValueOrDefault();
        }
    }
}
