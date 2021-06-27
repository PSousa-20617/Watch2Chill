using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Watch2Chill.Models;

namespace Watch2Chill.Data
{
    /// <summary>
    /// classe para recolher os dados particulares dos utilizadores
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        //recolhe a data de registo de um utilizador
        public DateTime DataRegisto { get; set; }
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);


            //// dados para definição dos roles
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "a", Name = "Admninistrador", NormalizedName = "ADMINISTRADOR" },
                new IdentityRole { Id = "u", Name = "Utilizador", NormalizedName = "UTILIZADOR" }
                );
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser { Id = "3d934ae8-b06a-40af-9037-ab0c50f1ead0", UserName = "admin1@admin1.com", NormalizedUserName = "ADMIN1@ADMIN1.COM", Email = "admin1@admin1.com", NormalizedEmail = "ADMIN1@ADMIN1.COM", EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEH6eG5iK1a2UIjLUrA+orXpHMC5Syj0a0EGgnOF/F+mKLSesM9jFG6wpcV1DV0usKw==", SecurityStamp = "3QUQ7ASRHRCZTI5BJ7UDYWBFAI6LY55C", ConcurrencyStamp = "976c1385-bc6f-42c1-9735-92ce8711f807" },
                new IdentityUser { Id = "9e2e24bf-9156-4caa-9f03-af7e1602d545", UserName = "utilizador@utilizador.com", NormalizedUserName = "UTILIZADOR@UTILIZADOR.COM", Email = "utilizador@utilizador.com", NormalizedEmail = "UTILIZADOR@UTILIZADOR.COM", EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEHEg7zCXQx/GezAiFnfJhQQtcOOdAWbAtslegNIpzENjJ6RtvTMWwwFcSBQyoDcXgw==", SecurityStamp = "Q7F6RPLAHL32WWX4DUI6JGCV5LLKX3XV", ConcurrencyStamp = "0b123ea8-0041-42a7-8a01-d739e6d7b358" }
                );
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = "3d934ae8-b06a-40af-9037-ab0c50f1ead0", RoleId = "a" },
                new IdentityUserRole<string> { UserId = "9e2e24bf-9156-4caa-9f03-af7e1602d545", RoleId = "u" }
                );
            modelBuilder.Entity<IdentityUserClaim<string>>().HasData(
                new IdentityUserClaim<string> { Id = 1, UserId = "3d934ae8-b06a-40af-9037-ab0c50f1ead0", ClaimType = "Nome", ClaimValue = "Administrador Administrador" },
                new IdentityUserClaim<string> { Id = 2, UserId = "9e2e24bf-9156-4caa-9f03-af7e1602d545", ClaimType = "Nome", ClaimValue = "Utilizador Utilizador" }
                );

            // insert DB seed

            //dados para testes durante o desenvolvimento
            modelBuilder.Entity<Utilizadores>().HasData(
               new Utilizadores { Id = 1, Nome = "Administrador", Email = "admin1@admin1.com", Morada = "Rua da Lua", Sexo = "M", DataNascimento = new DateTime(13 / 05 / 1990), UserName = "3d934ae8-b06a-40af-9037-ab0c50f1ead0", UserId = "3d934ae8-b06a-40af-9037-ab0c50f1ead0" },
               new Utilizadores { Id = 2, Nome = "Utilizador", Email = "utilizador@utilizador.com", Morada = "Rua da Lua", Sexo = "M", DataNascimento = new DateTime(09 / 02 / 1984), UserName = "9e2e24bf-9156-4caa-9f03-af7e1602d545", UserId = "9e2e24bf-9156-4caa-9f03-af7e1602d545" }
            );

            modelBuilder.Entity<UtilizadoresVideos>().HasData(
               new UtilizadoresVideos { Id = 1, IdUtilizadorFK = 1, IdVideoFK = 1 },
               new UtilizadoresVideos { Id = 2, IdUtilizadorFK = 2, IdVideoFK = 2 }
               //new UtilizadoresVideos { Id = 3, IdUtilizadorFK = 1, IdVideoFK = 3 }
            );

            modelBuilder.Entity<Videos>().HasData(
               new Videos { IdVideo = 1, Foto = "TheGodfather.jpg", Nome = "The Godfather", Genero = "Crime, Drama", Ano = 1972, Elenco = "Al Pacino, Marlon Brando, James Caan, Richard S. Castellano", Idioma = "Inglês", Realizador = "Francis Ford Coppola", NTemporadas = 0 },
               new Videos { IdVideo = 2, Foto = "TheDarkKnight.jpg", Nome = "The dark Knight", Genero = "Crime, Drama, Ação", Ano = 2008, Elenco = "Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine", Idioma = "Inglês", Realizador = "Christopher Nolan", NTemporadas = 0 },
               new Videos { IdVideo = 3, Foto = "TheLordOfTheRings.jpg", Nome = "The Lord of the Rings", Genero = "Aventura, Fantasia, Drama", Ano = 2001, Elenco = "Alan Howard, Noel Appleby, Sean Astin, Sala Baker", Idioma = "Inglês", Realizador = "Peter Jackson", NTemporadas = 0 },
               new Videos { IdVideo = 4, Foto = "StarWars.jpg", Nome = "Star Wars: Episode I", Genero = "Aventura, Ação, Fantasia", Ano = 1977, Elenco = "Mark Hamill, Harrison Ford, Carrie Fisher, Peter Cushing", Idioma = "Inglês", Realizador = "George Lucas", NTemporadas = 0 },
               new Videos { IdVideo = 5, Foto = "HarryPotter.jpg", Nome = "Harry Potter", Genero = "Fantasia, Aventura, Família", Ano = 2001, Elenco = "Daniel Radcliffe, Rupert Grint, Richard Harris", Idioma = "Inglês", Realizador = "Chris Columbus", NTemporadas = 0 },
               new Videos { IdVideo = 6, Foto = "BreakingBad.jpg", Nome = "Breaking Bad", Genero = "Drama, Crime, Thriller", Ano = 2008, Elenco = "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris", Idioma = "Inglês", Realizador = "Vince Gilligan", NTemporadas = 5 },
               new Videos { IdVideo = 7, Foto = "GameOfThrones.jpg", Nome = "Game of Thrones", Genero = "Aventura, Drama, Fantasia", Ano = 2011, Elenco = " Emilia Clarke, Peter Dinklage, Lena Headey, Peter Dinklage, Kit Harington", Idioma = "Inglês", Realizador = "D.B. Weiss, David Benioff", NTemporadas = 8 },
               new Videos { IdVideo = 8, Foto = "RickMorty.jpg", Nome = "Rick and Morty", Genero = "Animação, Aventura, Comédia", Ano = 2013, Elenco = "Justin Roiland, Chris Parnell, Spencer Grammer, Sarah Chalke", Idioma = "Inglês", Realizador = "Dan Harmon, Justin Roiland", NTemporadas = 4 },
               new Videos { IdVideo = 9, Foto = "solarOpposites.jpg", Nome = "Solar Opposites", Genero = "Animação, Faroeste, Ficção Científica", Ano = 2020, Elenco = "Justin Roiland, Sean Giambrone, Thomas Middleditch", Idioma = "Inglês", Realizador = "Justin Roiland, Mike McMahan", NTemporadas = 2 },
               new Videos { IdVideo = 10, Foto = "FinalSpace.jpg", Nome = "Final Space", Genero = "Animação, Aventura, Comédia", Ano = 2018, Elenco = "Olan Rogers, Fred Armisen, David Tennant", Idioma = "Inglês", Realizador = "Olan Rogers", NTemporadas = 3 }
            );

            modelBuilder.Entity<Temporadas>().HasData(
               new Temporadas { IdSerie = 1, NumTemps = 0, NumEps = 1, IdVideosFK = 1, Data =""},
               new Temporadas { IdSerie = 2, NumTemps = 0, NumEps = 1, IdVideosFK = 2, Data = "" },
               new Temporadas { IdSerie = 3, NumTemps = 0, NumEps = 1, IdVideosFK = 3, Data = "" },
               new Temporadas { IdSerie = 4, NumTemps = 0, NumEps = 1, IdVideosFK = 4, Data = "" },
               new Temporadas { IdSerie = 5, NumTemps = 0, NumEps = 1, IdVideosFK = 5, Data = "" },
               new Temporadas { IdSerie = 6, NumTemps = 5, NumEps = 62, IdVideosFK = 6, Data = "2015" },
               new Temporadas { IdSerie = 7, NumTemps = 3, NumEps = 73, IdVideosFK = 7, Data = "2019" },
               new Temporadas { IdSerie = 8, NumTemps = 4, NumEps = 41, IdVideosFK = 8, Data = "Ainda a decorrer" },
               new Temporadas { IdSerie = 9, NumTemps = 2, NumEps = 16, IdVideosFK = 9, Data = "Ainda a decorrer" },
               new Temporadas { IdSerie = 10, NumTemps = 3, NumEps = 30, IdVideosFK = 10, Data = "Ainda a decorrer" }
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