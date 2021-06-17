using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Watch2Chill.Models;

namespace Watch2Chill.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        /// <summary>
        /// construtor da classe ApplicationDbContext
        /// indicar onde está a BD à qual estas classes (tabelas) serão associadas
        /// ver o conteúdo do ficheiro 'startup.cs'
        /// </summary>
        /// <param name="options"></param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //importa todo o 'funcionamento' prévio do método
            base.OnModelCreating(modelBuilder);

            // insert DB seed

            modelBuilder.Entity<Utilizadores>().HasData(
               new Utilizadores { Id = 1, Nome = "Fernando Fernao", Email = "a@a.a", Morada = "Rua do Lago",CodPostal= "2313-231", Sexo = "M", DataNascimento = new DateTime(13 / 05 / 1990) },
               new Utilizadores { Id = 2, Nome = "Rodrigo Rodrigues", Email = "b@b.b", Morada = "Rua da Estrela", CodPostal = "3100-121", Sexo = "M", DataNascimento = new DateTime(09 / 02 / 1984) },
               new Utilizadores { Id = 3, Nome = "Gonçalo Gonçalves", Email = "c@c.c", Morada = "Rua da Lua", CodPostal = "3152-344", Sexo = "M", DataNascimento = new DateTime(25 / 08 / 1993) },
               new Utilizadores { Id = 4, Nome = "Maria Silva", Email = "d@d.d", Morada = "Rua do Sol", CodPostal = "1222-783", Sexo = "F", DataNascimento = new DateTime(30 / 11 / 1987) },
               new Utilizadores { Id = 5, Nome = "Bernardo Alentejo", Email = "e@e.e", Morada = "Rua da Ribeira", CodPostal = "1284-231", Sexo = "M", DataNascimento = new DateTime(19 / 04 / 1997) }
            );

            modelBuilder.Entity<UtilizadoresVideos>().HasData(
               new UtilizadoresVideos { Id = 1, IdUtilizadorFK = 2, IdVideoFK = 1 },
               new UtilizadoresVideos { Id = 2, IdUtilizadorFK = 3, IdVideoFK = 2 },
               new UtilizadoresVideos { Id = 3, IdUtilizadorFK = 4, IdVideoFK = 3 }
            );

            modelBuilder.Entity<Videos>().HasData(
               new Videos { IdVideo = 1, Nome = "The Godfather", Genero = "Crime, Drama", Ano = 1972, Elenco = "Al Pacino, Marlon Brando, James Caan, Richard S. Castellano", Idioma = "Inglês", Realizador = "Francis Ford Coppola", NTemporadas = 0 },
               new Videos { IdVideo = 2, Nome = "The dark Knight", Genero = "Crime, Drama, Ação", Ano = 2008, Elenco = "Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine", Idioma = "Inglês", Realizador = "Christopher Nolan", NTemporadas = 0 },
               new Videos { IdVideo = 3, Nome = "The Lord of the Rings", Genero = "Aventura, Fantasia, Drama", Ano = 2001, Elenco = "Alan Howard, Noel Appleby, Sean Astin, Sala Baker", Idioma = "Inglês", Realizador = "Peter Jackson", NTemporadas = 0 },
               new Videos { IdVideo = 4, Nome = "Star Wars: Episode I", Genero = "Aventura, Ação, Fantasia", Ano = 1977, Elenco = "Mark Hamill, Harrison Ford, Carrie Fisher, Peter Cushing", Idioma = "Inglês", Realizador = "George Lucas", NTemporadas = 0 },
               new Videos { IdVideo = 5, Nome = "Harry Potter", Genero = "Fantasia, Aventura, Família", Ano = 2001, Elenco = "Daniel Radcliffe, Rupert Grint, Richard Harris", Idioma = "Inglês", Realizador = "Chris Columbus", NTemporadas = 0 },
               new Videos { IdVideo = 6, Nome = "Breaking Bad", Genero = "Drama, Crime, Thriller", Ano = 2008, Elenco = "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris", Idioma = "Inglês", Realizador = "Vince Gilligan", NTemporadas = 5 },
               new Videos { IdVideo = 7, Nome = "Game of Thrones", Genero = "Aventura, Drama, Fantasia", Ano = 2011, Elenco = " Emilia Clarke, Peter Dinklage, Lena Headey, Peter Dinklage, Kit Harington", Idioma = "Inglês", Realizador = "D.B. Weiss, David Benioff", NTemporadas = 8 },
               new Videos { IdVideo = 8, Nome = "Rick and Morty", Genero = "Animação, Aventura, Comédia", Ano = 2013, Elenco = "Justin Roiland, Chris Parnell, Spencer Grammer, Sarah Chalke", Idioma = "Inglês", Realizador = "Dan Harmon, Justin Roiland", NTemporadas = 41 },
               new Videos { IdVideo = 9, Nome = "Solar Opposites", Genero = "Animação, Faroeste, Ficção Científica", Ano = 2020, Elenco = "Justin Roiland, Sean Giambrone, Thomas Middleditch", Idioma = "Inglês", Realizador = "Justin Roiland, Mike McMahan", NTemporadas = 2 },
               new Videos { IdVideo = 10, Nome = "Final Space", Genero = "Animação, Aventura, Comédia", Ano = 2018, Elenco = "Olan Rogers, Fred Armisen, David Tennant", Idioma = "Inglês", Realizador = "Olan Rogers", NTemporadas = 3 }
            );

            modelBuilder.Entity<Temporadas>().HasData(
               new Temporadas { IdSerie = 1, NumTemps = 0, NumEps = 1, IdVideosFK = 1 },
               new Temporadas { IdSerie = 2, NumTemps = 0, NumEps = 1, IdVideosFK = 2 },
               new Temporadas { IdSerie = 3, NumTemps = 0, NumEps = 1, IdVideosFK = 3 },
               new Temporadas { IdSerie = 4, NumTemps = 0, NumEps = 1, IdVideosFK = 4 },
               new Temporadas { IdSerie = 5, NumTemps = 0, NumEps = 1, IdVideosFK = 5 },
               new Temporadas { IdSerie = 6, NumTemps = 5, NumEps = 62, IdVideosFK = 6, DataFim = "2015" },
               new Temporadas { IdSerie = 7, NumTemps = 3, NumEps = 73, IdVideosFK = 7, DataFim = "2019" },
               new Temporadas { IdSerie = 8, NumTemps = 4, NumEps = 41, IdVideosFK = 8, DataFim = "Ainda a decorrer" },
               new Temporadas { IdSerie = 9, NumTemps = 2, NumEps = 16, IdVideosFK = 9, DataFim = "Ainda a decorrer" },
               new Temporadas { IdSerie = 10, NumTemps = 3, NumEps = 30, IdVideosFK = 10, DataFim = "Ainda a decorrer" }
            );

            modelBuilder.Entity<Episodios>().HasData(
               new Episodios { Id = 1, Nome = "The Godfather", Id_serieFK = 0 },
               new Episodios { Id = 2, Nome = "The dark Knight", Id_serieFK = 0 },
               new Episodios { Id = 3, Nome = "The Lord of the Rings", Id_serieFK = 0 },
               new Episodios { Id = 4, Nome = "Star Wars: Episode I", Id_serieFK = 0 },
               new Episodios { Id = 5, Nome = "Harry Potter", Id_serieFK = 0 },
               new Episodios { Id = 6, Nome = "Pilot", Id_serieFK = 1 },
               new Episodios { Id = 7, Nome = "Winter Is Coming", Id_serieFK = 1 },
               new Episodios { Id = 8, Nome = "Pilot", Id_serieFK = 1 },
               new Episodios { Id = 9, Nome = "The Matter Transfer Array", Id_serieFK = 1 },
               new Episodios { Id = 10, Nome = "Chapter One", Id_serieFK = 1 }
            );

        }

        public DbSet<Utilizadores> Utilizadores { get; set; }
        public DbSet<UtilizadoresVideos> UtilizadoresVideos { get; set; }
        public DbSet<Videos> Videos { get; set; }
        public DbSet<Temporadas> Temporadas { get; set; }
        public DbSet<Episodios> Episodios { get; set; }

    }
}

