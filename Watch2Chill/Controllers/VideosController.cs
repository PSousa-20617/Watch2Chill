using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Watch2Chill.Data;
using Watch2Chill.Models;

namespace Watch2Chill.Controllers
{

    [Authorize]
    public class VideosController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _caminho;

        private readonly UserManager<IdentityUser> _userManager;
        public VideosController(
            ApplicationDbContext context,
            IWebHostEnvironment caminho,
            UserManager<IdentityUser> userManager)
        {
            _context = context;
            _caminho = caminho;
            _userManager = userManager;
        }


        // GET: Videos
        [AllowAnonymous] //anula a necessidade de um utilizador estar autenticado para aceder a este metodo
        public async Task<IActionResult> Index()
        {
            var videos = _context.Videos.Include(v => v.Foto);
            return View(await _context.Videos.ToListAsync());
        }

        // GET: Videos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var videos = await _context.Videos
                .Include(v => v.ListaDeTemporadas)
                .Include(v => v.ListaDeUtilizadores)
                .ThenInclude(uv => uv.IdUtilizador.UserName == _userManager.GetUserId(User))
                .FirstOrDefaultAsync(m => m.IdVideo == id);
            if (videos == null)
            {
                return RedirectToAction("Index");
            }
            //?????????????????????????????????????????????????????????????????????
            return View(videos);
        }

        // GET: Videos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Videos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVideo,Foto,Nome,Trailer,Genero,Ano,Elenco,Idioma,Realizador,Filme,NTemporadas")] Videos videos, IFormFile fotoVideo)
        {
            // var auxiliar
            string nomeImagem = "";

            if (fotoVideo == null)
            {
                //não ha ficheiro
                ModelState.AddModelError("", "Adicione por favor a capa do video");
                ViewData["IdVideo"] = new SelectList(_context.Videos.OrderBy(v => v.Nome), "IdVideo", "Nome", videos.IdVideo);
                return View(videos);
            }
            else
            {
                //ha ficheiro mas sera valido
                if (fotoVideo.ContentType == "image/jpeg" || fotoVideo.ContentType == "image/png")
                {

                    // definir o novo nome da fotografia     
                    Guid g;
                    g = Guid.NewGuid();
                    nomeImagem = videos.IdVideo + "_" + g.ToString(); // tb, poderia ser usado a formatação da data atual
                                                                  // determinar a extensão do nome da imagem
                    string extensao = Path.GetExtension(fotoVideo.FileName).ToLower();
                    // agora, consigo ter o nome final do ficheiro
                    nomeImagem = nomeImagem + extensao;

                    // associar este ficheiro aos dados da Fotografia do cão
                    videos.Foto = nomeImagem;

                    // localização do armazenamento da imagem
                    string localizacaoFicheiro = _caminho.WebRootPath;
                    nomeImagem = Path.Combine(localizacaoFicheiro, "Imagens\\Videos", nomeImagem);
                }

                else
                {
                    //ficheiro não valido
                    ModelState.AddModelError("", "Apenas pode associar uma imagem a um video.");
                    return View(videos);

                }
            }
            if (ModelState.IsValid)
            {
                try
                {
                    //adicionar dados do novo video
                    _context.Add(videos);
                    //
                    await _context.SaveChangesAsync();

                    //se cheguei, tudo correu bem
                    using var stream = new FileStream(nomeImagem, FileMode.Create);
                    await fotoVideo.CopyToAsync(stream);

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Ocorreu um erro...");
                }
            }
            return View(videos);
        }

        // GET: Videos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videos = await _context.Videos.FindAsync(id);
            if (videos == null)
            {
                return NotFound();
            }

            //???????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????
            //problema com guardar id da foto

            // guardar o ID do objeto enviado para o browser
            // através de uma variável de sessão
            //HttpContext.Session.SetInt32("NumFotoEmEdicao", videos.IdVideo);
            //SessionExtensions["NumFotoEmEdicao"] = videos.Foto;
            //HttpContext.Session.SetString("NumFotoEmEdicao", videos.Foto);

            return View(videos);
        }

        // POST: Videos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVideo,Foto,Nome,Trailer,Genero,Ano,Elenco,Idioma,Realizador,Filme,NTemporadas")] Videos videos)
        {
            if (id != videos.IdVideo)
            {
                return NotFound();
            }
            /*
            // recuperar o ID do objeto enviado para o browser
            var numIdFoto = HttpContext.Session.GetInt32("NumFotoEmEdicao");
            //var Foto = HttpContext.Session.GetString("NumFotoEmEdicao");

            // e compará-lo com o ID recebido
            // se forem iguais, continuamos
            // se forem diferentes, não fazemos a alteração

            if (numIdFoto == null || numIdFoto != videos.IdVideo)
            {
                // se entro aqui, é pq houve problemas

                // redirecionar para a página de início
                return RedirectToAction("Index");
            }*/

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(videos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VideosExists(videos.IdVideo))
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

            return View(videos);
        }

        // GET: Videos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videos = await _context.Videos
                .FirstOrDefaultAsync(m => m.IdVideo == id);
            if (videos == null)
            {
                return NotFound();
            }

            return View(videos);
        }

        // POST: Videos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var videos = await _context.Videos.FindAsync(id);
            _context.Videos.Remove(videos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VideosExists(int id)
        {
            return _context.Videos.Any(e => e.IdVideo == id);
        }
    }
}
