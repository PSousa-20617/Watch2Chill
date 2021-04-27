using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watch2Chill.Models;

namespace Watch2Chill.Data
{
    public class Watch2ChillDB :DbContext {

        public Watch2ChillDB(DbContextOptions<Watch2ChillDB> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            // insert DB seed

            modelBuilder.Entity<Utilizadores>().HasData(
               new Utilizadores { Id = 1, Nome = "Fernando Fernao", Email = "a@a.a", Morada = "Rua do Lago", Sexo = "M", Data_nascimento = new DateTime(13 / 05 / 1990), Tipo = "Anonimo" },
               new Utilizadores { Id = 2, Nome = "Rodrigo Rodrigues", Email = "b@b.b", Morada = "Rua da Estrela", Sexo = "M", Data_nascimento = new DateTime(09 / 02 / 1984), Tipo = "Autenticado" },
               new Utilizadores { Id = 3, Nome = "Gonçalo Gonçalves", Email = "c@c.c", Morada = "Rua da Lua", Sexo = "M", Data_nascimento = new DateTime(25 / 08 / 1993), Tipo = "Autenticado" },
               new Utilizadores { Id = 4, Nome = "Maria Silva", Email = "d@d.d", Morada = "Rua do Sol", Sexo = "F", Data_nascimento = new DateTime(30 / 11 / 1987), Tipo = "Autenticado" },
               new Utilizadores { Id = 5, Nome = "Bernardo Alentejo", Email = "e@e.e", Morada = "Rua da Ribeira", Sexo = "M", Data_nascimento = new DateTime(19 / 04 / 1997), Tipo = "Anonimo" }
            );

            modelBuilder.Entity<Utilizadores_videos>().HasData(
               new Utilizadores_videos { Id_Utilizadores = 2, Id_Videos = 1 },
               new Utilizadores_videos { Id_Utilizadores = 3, Id_Videos = 2 },
               new Utilizadores_videos { Id_Utilizadores = 4, Id_Videos = 3 }
            );

            modelBuilder.Entity<Videos>().HasData(
               new Videos { Id = 1, Nome = "The Godfather", Genero = "Crime, Drama", Ano = "1972", Elenco = "Al Pacino, Marlon Brando, James Caan, Richard S. Castellano", Idioma = "Inglês", Realizador = "Francis Ford Coppola", N_temporadas = "0", N_episodios = "1" },
               new Videos { Id = 2, Nome = "The dark Knight", Genero = "Crime, Drama, Ação", Ano = "2008", Elenco = "Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine", Idioma = "Inglês", Realizador = "Christopher Nolan", N_temporadas = "0", N_episodios = "1" },
               new Videos { Id = 3, Nome = "The Lord of the Rings", Genero = "Aventura, Fantasia, Drama", Ano = "2001", Elenco = "Alan Howard, Noel Appleby, Sean Astin, Sala Baker", Idioma = "Inglês", Realizador = "Peter Jackson", N_temporadas = "0", N_episodios = "1" },
               new Videos { Id = 4, Nome = "Star Wars: Episode I", Genero = "Aventura, Ação, Fantasia", Ano = "1977", Elenco = "Mark Hamill, Harrison Ford, Carrie Fisher, Peter Cushing", Idioma = "Inglês", Realizador = "George Lucas", N_temporadas = "0", N_episodios = "1" },
               new Videos { Id = 5, Nome = "Harry Potter", Genero = "Fantasia, Aventura, Família", Ano = "2001", Elenco = "Daniel Radcliffe, Rupert Grint, Richard Harris", Idioma = "Inglês", Realizador = "Chris Columbus", N_temporadas = "0", N_episodios = "1" },
               new Videos { Id = 6, Nome = "Breaking Bad", Genero = "Drama, Crime, Thriller", Ano = "2008/2015", Elenco = "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris", Idioma = "Inglês", Realizador = "Vince Gilligan", N_temporadas = "5", N_episodios = "62" },
               new Videos { Id = 7, Nome = "Game of Thrones", Genero = "Aventura, Drama, Fantasia", Ano = "2011/2019", Elenco = " Emilia Clarke, Peter Dinklage, Lena Headey, Peter Dinklage, Kit Harington", Idioma = "Inglês", Realizador = "D.B. Weiss, David Benioff", N_temporadas = "8", N_episodios = "73" },
               new Videos { Id = 8, Nome = "Rick and Morty", Genero = "Animação, Aventura, Comédia", Ano = "2013/Presente", Elenco = "Justin Roiland, Chris Parnell, Spencer Grammer, Sarah Chalke", Idioma = "Inglês", Realizador = "Dan Harmon, Justin Roiland", N_temporadas = "4", N_episodios = "41" },
               new Videos { Id = 9, Nome = "Solar Opposites", Genero = "Animação, Faroeste, Ficção Científica", Ano = "2020/Presente", Elenco = "Justin Roiland, Sean Giambrone, Thomas Middleditch", Idioma = "Inglês", Realizador = "Justin Roiland, Mike McMahan", N_temporadas = "2", N_episodios = "16" },
               new Videos { Id = 10, Nome = "Final Space", Genero = "Animação, Aventura, Comédia", Ano = "2018/Presente", Elenco = "Olan Rogers, Fred Armisen, David Tennant", Idioma = "Inglês", Realizador = "Olan Rogers", N_temporadas = "3", N_episodios = "30" }
            );

            modelBuilder.Entity<Temporadas>().HasData(
               new Temporadas { Num = "0", N_episódios = "1", Id_VideosFK = 1 },
               new Temporadas { Num = "0", N_episódios = "1", Id_VideosFK = 2 },
               new Temporadas { Num = "0", N_episódios = "1", Id_VideosFK = 3 },
               new Temporadas { Num = "0", N_episódios = "1", Id_VideosFK = 4 },
               new Temporadas { Num = "0", N_episódios = "1", Id_VideosFK = 5 },
               new Temporadas { Num = "5", N_episódios = "62", Id_VideosFK = 6 },
               new Temporadas { Num = "8", N_episódios = "73", Id_VideosFK = 7 },
               new Temporadas { Num = "4", N_episódios = "41", Id_VideosFK = 8 },
               new Temporadas { Num = "2", N_episódios = "16", Id_VideosFK = 9 },
               new Temporadas { Num = "3", N_episódios = "30", Id_VideosFK = 10 }
            );

            modelBuilder.Entity<Episodios>().HasData(
               new Episodios { Id = 1, Nome = "The Godfather", Num_temporadaFK = "0" },
               new Episodios { Id = 2, Nome = "The dark Knight", Num_temporadaFK = "0" },
               new Episodios { Id = 3, Nome = "The Lord of the Rings", Num_temporadaFK = "0" },
               new Episodios { Id = 4, Nome = "Star Wars: Episode I", Num_temporadaFK = "0" },
               new Episodios { Id = 5, Nome = "Harry Potter", Num_temporadaFK = "0" },
               new Episodios { Id = 6, Nome = "Pilot", Num_temporadaFK = "1" },
               new Episodios { Id = 7, Nome = "Winter Is Coming", Num_temporadaFK = "1" },
               new Episodios { Id = 8, Nome = "Pilot", Num_temporadaFK = "1" },
               new Episodios { Id = 9, Nome = "The Matter Transfer Array", Num_temporadaFK = "1" },
               new Episodios { Id = 10, Nome = "Chapter One", Num_temporadaFK = "1" }
            );

        }

        public DbSet<Utilizadores> Utilizadores { get; set; }

        public DbSet<Utilizadores_videos> Utilizadores_videos { get; set; }

        public DbSet<Videos> Videos { get; set; }

        public DbSet<Temporadas> Temporadas { get; set; }

        public DbSet<Episodios> Episodios { get; set; }

    }
}
