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
    public class TipoHospedagemController : Controller
    {
        private readonly Contexto _context;

        public TipoHospedagemController(Contexto context)
        {
            _context = context;
        }

        // GET: TipoHospedagem
        public async Task<IActionResult> Index()
        {
              return _context.TipoHospedagem != null ? 
                          View(await _context.TipoHospedagem.ToListAsync()) :
                          Problem("Entity set 'Contexto.TipoHospedagem'  is null.");
        }

        // GET: TipoHospedagem/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TipoHospedagem == null)
            {
                return NotFound();
            }

            var tipoHospedagem = await _context.TipoHospedagem
                .FirstOrDefaultAsync(m => m.TipoHospedagemId == id);
            if (tipoHospedagem == null)
            {
                return NotFound();
            }

            return View(tipoHospedagem);
        }

        // GET: TipoHospedagem/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoHospedagem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipoHospedagemId,TipoHospedagemNome")] TipoHospedagem tipoHospedagem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoHospedagem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoHospedagem);
        }

        // GET: TipoHospedagem/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TipoHospedagem == null)
            {
                return NotFound();
            }

            var tipoHospedagem = await _context.TipoHospedagem.FindAsync(id);
            if (tipoHospedagem == null)
            {
                return NotFound();
            }
            return View(tipoHospedagem);
        }

        // POST: TipoHospedagem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TipoHospedagemId,TipoHospedagemNome")] TipoHospedagem tipoHospedagem)
        {
            if (id != tipoHospedagem.TipoHospedagemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoHospedagem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoHospedagemExists(tipoHospedagem.TipoHospedagemId))
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
            return View(tipoHospedagem);
        }

        // GET: TipoHospedagem/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TipoHospedagem == null)
            {
                return NotFound();
            }

            var tipoHospedagem = await _context.TipoHospedagem
                .FirstOrDefaultAsync(m => m.TipoHospedagemId == id);
            if (tipoHospedagem == null)
            {
                return NotFound();
            }

            return View(tipoHospedagem);
        }

        // POST: TipoHospedagem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TipoHospedagem == null)
            {
                return Problem("Entity set 'Contexto.TipoHospedagem'  is null.");
            }
            var tipoHospedagem = await _context.TipoHospedagem.FindAsync(id);
            if (tipoHospedagem != null)
            {
                _context.TipoHospedagem.Remove(tipoHospedagem);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoHospedagemExists(int id)
        {
          return (_context.TipoHospedagem?.Any(e => e.TipoHospedagemId == id)).GetValueOrDefault();
        }
    }
}
