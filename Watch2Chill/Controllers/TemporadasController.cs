using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Watch2Chill.Data;
using Watch2Chill.Models;

namespace Watch2Chill.Controllers
{
    [Authorize]
    public class TemporadasController : Controller
    {
        /// <summary>
        /// referência à base de dados
        /// </summary>
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// objeto que sabe interagir com os dados do utilizador que se autêntica
        /// </summary>
        public TemporadasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Temporadas
        public async Task<IActionResult> Index()
        {
            //criação de uma variavel que vai conter um conjunto d dados vindos da base de dados
            var temporadas = _context.Temporadas
                                     .Include(t => t.ListaDeEpisodios)
                                     .Include(t => t.Video);

            return View(await temporadas.ToListAsync());
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
        [Authorize(Roles = "Admninistrador")]
        public IActionResult Create()
        {
            //geração da lista de valores disponíveis na dropdown
            //o viewData transporta dados a serem associados ao atributo idVideosFK
            //o selectList é um tipo de dados especial que serve para armazenar a lista de opções de um objeto do tipo
            //select do html
            ViewData["IdVideosFK"] = new SelectList(_context.Videos.OrderBy(v => v.Nome), "IdVideo", "Nome");
            return View();
        }

        // POST: Temporadas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSerie,NumTemps,NumEps,Data,IdVideosFK")] Temporadas temporada)
        {
            if(temporada.IdVideosFK > 0) 
            { 

                if (ModelState.IsValid)
                {
                    try 
                    { 
                        _context.Add(temporada);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                    catch(Exception ex)
                    {
                        ModelState.AddModelError("", "Ocorreu um erro...");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Por favor, escolha um video");
                }
            }
            ViewData["IdVideosFK"] = new SelectList(_context.Videos.OrderBy(v => v.Nome), "IdVideo", "Nome", temporada.IdVideosFK);
            return View(temporada);
        }

        // GET: Temporadas/Edit/5
        [Authorize(Roles = "Admninistrador")]
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
        public async Task<IActionResult> Edit(int id, [Bind("IdSerie,NumTemps,NumEps,Data,IdVideosFK")] Temporadas temporadas)
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
        [Authorize(Roles = "Admninistrador")]
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
