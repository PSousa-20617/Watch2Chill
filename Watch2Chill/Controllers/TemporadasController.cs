using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Watch2Chill.Data;
using Watch2Chill.Models;

namespace Watch2Chill.Controllers
{
    public class TemporadasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TemporadasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Temporadas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Temporadas.ToListAsync());
        }

        // GET: Temporadas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var temporadas = await _context.Temporadas
                .FirstOrDefaultAsync(m => m.IdSerie == id);
            if (temporadas == null)
            {
                return NotFound();
            }

            return View(temporadas);
        }

        // GET: Temporadas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Temporadas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSerie,NumTemps,NumEps,DataFim,IdVideosFK")] Temporadas temporadas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(temporadas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(temporadas);
        }

        // GET: Temporadas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var temporadas = await _context.Temporadas.FindAsync(id);
            if (temporadas == null)
            {
                return NotFound();
            }
            return View(temporadas);
        }

        // POST: Temporadas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSerie,NumTemps,NumEps,DataFim,IdVideosFK")] Temporadas temporadas)
        {
            if (id != temporadas.IdSerie)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(temporadas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TemporadasExists(temporadas.IdSerie))
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
            return View(temporadas);
        }

        // GET: Temporadas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var temporadas = await _context.Temporadas
                .FirstOrDefaultAsync(m => m.IdSerie == id);
            if (temporadas == null)
            {
                return NotFound();
            }

            return View(temporadas);
        }

        // POST: Temporadas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var temporadas = await _context.Temporadas.FindAsync(id);
            _context.Temporadas.Remove(temporadas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TemporadasExists(int id)
        {
            return _context.Temporadas.Any(e => e.IdSerie == id);
        }
    }
}
