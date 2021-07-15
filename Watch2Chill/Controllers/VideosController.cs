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
        /// <summary>
        /// este atributo representa a base de dados do projeto
        /// </summary>
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// este atributo contém os dados da app web no servidor
        /// </summary>
        private readonly IWebHostEnvironment _caminho;

        /// <summary>
        /// esta variável recolhe os dados da pessoa q se autenticou
        /// </summary>
        private readonly UserManager<ApplicationUser> _userManager;

        public VideosController(
            ApplicationDbContext context,
            IWebHostEnvironment caminho,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _caminho = caminho;
            _userManager = userManager;
        }


        // GET: Videos
        [AllowAnonymous] //anula a necessidade de um utilizador estar autenticado para aceder a este método
        public async Task<IActionResult> Index()
        {
            var videos = _context.Videos
                .Include(v => v.Foto)
                .Include(v => v.ListaDeTemporadas)
                .Include(v => v.ListaDeUtilizadores)
                .ThenInclude(uv => uv.Utilizador.UserName == _userManager.GetUserId(User));

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
                                       .Include(v => v.ListaDeUtilizadores)
                                       .ThenInclude(uv => uv.Utilizador)
                                       .FirstOrDefaultAsync(m => m.IdVideo == id);
            if (videos == null)
            {
                // redirecionar para a página de início
                return RedirectToAction("Index");
            }

            return View(videos);
        }




        // GET: Videos/Gosto/5
        [HttpPost]
        public async Task<IActionResult> Gosto(int? idDoVideo)
        {
            if (idDoVideo == null)
            {
                return RedirectToAction("Index");
            }

            // verificar se o filme indicado realmente existe
            var video = await _context.Videos.FirstOrDefaultAsync(m => m.IdVideo == idDoVideo);
            if (video == null)
            {
                // redirecionar para a página de início
                return RedirectToAction("Index");
            }

            // se cheguei aqui, é porque existe filme.
            // procurar os dados do utilizador autenticado
            Utilizadores utilizador = await _context.Utilizadores.Where(u => u.UserName == _userManager.GetUserId(User)).FirstOrDefaultAsync();

            // criar objeto com dados que ligam o utilizador e o filme
            // começar por procurar se o utilizador já 'gostou' do filme
            var gostouDoFilme = await _context.UtilizadoresVideos.Where(uv => uv.Video == video && uv.Utilizador == utilizador).FirstOrDefaultAsync();

            if (gostouDoFilme != null)
            {
                // existe este objeto => o utilizador já gostou do filme,
                // mas, agora já não gosta
                _context.Remove(gostouDoFilme);
            }
            else
            {
                // afinal, sempre gosta do filme...
                gostouDoFilme = new UtilizadoresVideos
                {
                    Video = video,
                    Utilizador = utilizador
                };
                _context.Add(gostouDoFilme);
            }

            try
            {
                // consolidar as alterações na BD
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return RedirectToAction("Details", new { id = idDoVideo });
        }



        // GET: Videos/Create
        [Authorize(Roles = "Admninistrador")]
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
                //não há ficheiro
                ModelState.AddModelError("", "Adicione por favor a capa do video");
                ViewData["IdVideo"] = new SelectList(_context.Videos.OrderBy(v => v.Nome), "IdVideo", "Nome", videos.IdVideo);
                return View(videos);
            }
            else
            {
                //há ficheiro mas será válido
                if (fotoVideo.ContentType == "image/jpeg" || fotoVideo.ContentType == "image/png")
                {

                    // definir o novo nome da fotografia     
                    Guid g;
                    g = Guid.NewGuid();
                    nomeImagem = videos.IdVideo + "_" + g.ToString(); // também poderia ser usada a formatação da data atual
                                                                      // determinar a extensão do nome da imagem
                    string extensao = Path.GetExtension(fotoVideo.FileName).ToLower();
                    // nome final do ficheiro
                    nomeImagem = nomeImagem + extensao;

                    // associar este ficheiro aos dados da Fotografia do video
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
                    //adicionar dados do novo vídeo
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
        [Authorize(Roles = "Admninistrador")]
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
        [Authorize(Roles = "Admninistrador")]
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
