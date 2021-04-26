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
               new Utilizadores { Id = 1, Nome = "Fernando Fernao", Email = "a@a.a", Morada = "Rua do Lago", Sexo = "M", Data_nascimento = "13/05/1990", Tipo = "Anonimo" },
               new Utilizadores { Id = 2, Nome = "Rodrigo Rodrigues", Email = "b@b.b", Morada = "Rua da Estrela", Sexo = "M", Data_nascimento = "09/02/1984", Tipo = "Autenticado" },
               new Utilizadores { Id = 3, Nome = "Gonçalo Gonçalves", Email = "c@c.c", Morada = "Rua da Lua", Sexo = "M", Data_nascimento = "25/08/1993", Tipo = "Autenticado" },
               new Utilizadores { Id = 4, Nome = "Maria Silva", Email = "d@d.d", Morada = "Rua do Sol", Sexo = "F", Data_nascimento = "30/11/1987", Tipo = "Autenticado" },
               new Utilizadores { Id = 5, Nome = "Bernardo Alentejo", Email = "e@e.e", Morada = "Rua da Ribeira", Sexo = "M", Data_nascimento = "19/04/1997", Tipo = "Anonimo" }
            );

            modelBuilder.Entity<Utilizadores_videos>().HasData(
               new Utilizadores_videos { Id_Utilizadores = 1, Id_Videos = },
               new Utilizadores_videos { Id_Utilizadores = 2, Id_Videos },
               new Utilizadores_videos { Id_Utilizadores = 4, Id_Videos },
               new Utilizadores_videos { Id_Utilizadores = 5, Id_Videos }
            );

            modelBuilder.Entity<Videos>().HasData(
               new Videos { Id = 1, Nome = "The Godfather", Genero = "F", Ano = new DateTime(2019, 4, 16), Elenco = "LOP446793", Idioma = 1, Realizador, N_temporadas, N_episodios },
               new Videos { Id = 2, Nome = "The dark Knight", Genero = "F", Ano = new DateTime(2019, 10, 10), Elenco = "LOP446795", Idioma = 1, Realizador, N_temporadas, N_episodios },
               new Videos { Id = 3, Nome = "The Lord of the Rings", Genero = "F", Ano = new DateTime(2011, 3, 22), Elenco = "LOP446801", Idioma = 5, Realizador, N_temporadas, N_episodios },
               new Videos { Id = 4, Nome = "Star Wars: Episode I", Genero = "F", Ano = new DateTime(2008, 6, 8), Elenco = "LOP446804", Idioma = 5, Realizador, N_temporadas, N_episodios },
               new Videos { Id = 5, Nome = "Now You See Me ", Genero = "F", Ano = new DateTime(2012, 8, 21), Elenco = "LOP446807", Idioma = 2, Realizador, N_temporadas, N_episodios },
               new Videos { Id = 6, Nome = "Breaking Bad", Genero = "F", Ano = new DateTime(2010, 10, 1), Elenco = "LOP446809", Idioma = 6, Realizador, N_temporadas, N_episodios },
               new Videos { Id = 7, Nome = "Game of Thrones", Genero = "F", Ano = new DateTime(2010, 12, 11), Elenco = "LOP446811", Idioma = 3, Realizador, N_temporadas, N_episodios },
               new Videos { Id = 8, Nome = "Rick and Morty", Genero = "F", Ano = new DateTime(2013, 4, 22), Elenco = "LOP446799", Idioma = 7, Realizador, N_temporadas, N_episodios },
               new Videos { Id = 9, Nome = "Solar Opposites", Genero = "M", Ano = new DateTime(2011, 5, 10), Elenco = "LOP446812", Idioma = 7, Realizador, N_temporadas, N_episodios },
               new Videos { Id = 10, Nome = "Final Space", Genero = "F", Ano = new DateTime(2017, 3, 21), Elenco = "LOP446814", Idioma = 4, Realizador, N_temporadas, N_episodios },
            );

            modelBuilder.Entity<Fotografias>().HasData(
               new Fotografias { Id = 1, Fotografia = "Retriever_do_labrador.jpg", Local = "", DataFoto = new DateTime(2019, 5, 20), CaoFK = 1 },
               new Fotografias { Id = 2, Fotografia = "Retriever_do_labrador_2.jpg", Local = "", DataFoto = new DateTime(2019, 5, 20), CaoFK = 1 },
               new Fotografias { Id = 3, Fotografia = "Retriever_do_labrador_3.jpg", Local = "", DataFoto = new DateTime(2019, 11, 18), CaoFK = 2 },
               new Fotografias { Id = 4, Fotografia = "s.bernardo.jpg", Local = "", DataFoto = new DateTime(2021, 1, 17), CaoFK = 3 },
               new Fotografias { Id = 5, Fotografia = "s.bernardo_2.jpg", Local = "casa", DataFoto = new DateTime(2019, 3, 7), CaoFK = 4 },
               new Fotografias { Id = 6, Fotografia = "serra_da_estrela.jpg", Local = "", DataFoto = new DateTime(2013, 10, 21), CaoFK = 5 },
               new Fotografias { Id = 7, Fotografia = "serra_da_estrela_2.jpg", Local = "", DataFoto = new DateTime(2012, 10, 1), CaoFK = 5 },
               new Fotografias { Id = 8, Fotografia = "Rafeiro_do_Alentejo.jpg", Local = "Quinta", DataFoto = new DateTime(2020, 10, 1), CaoFK = 6 },
               new Fotografias { Id = 9, Fotografia = "pastor_alemao_2.jpg", Local = "", DataFoto = new DateTime(2011, 1, 4), CaoFK = 7 },
               new Fotografias { Id = 10, Fotografia = "pastor_alemao.jpg", Local = "", DataFoto = new DateTime(2020, 12, 6), CaoFK = 7 },
               new Fotografias { Id = 11, Fotografia = "golden-retriever_2.jpg", Local = "", DataFoto = new DateTime(2018, 12, 23), CaoFK = 8 },
               new Fotografias { Id = 12, Fotografia = "golden-retriever.jpg", Local = "ninhada", DataFoto = new DateTime(2017, 1, 5), CaoFK = 8 },
               new Fotografias { Id = 13, Fotografia = "Golden-Retriever-1.jpg", Local = "", DataFoto = new DateTime(2020, 2, 2), CaoFK = 9 },
               new Fotografias { Id = 14, Fotografia = "Dogue_Alemao.jpg", Local = "Casa da tia Ana", DataFoto = new DateTime(2021, 4, 13), CaoFK = 10 },
               new Fotografias { Id = 15, Fotografia = "border_collie.jpg", Local = "quintal", DataFoto = new DateTime(2021, 2, 4), CaoFK = 11 }
            );

            modelBuilder.Entity<CriadoresCaes>().HasData(
               new CriadoresCaes { Id = 1, DataCompra = new DateTime(2019, 6, 15), CaoFK = 1, CriadorFK = 1 },
               new CriadoresCaes { Id = 2, DataCompra = new DateTime(2019, 12, 9), CaoFK = 2, CriadorFK = 2 },
               new CriadoresCaes { Id = 3, DataCompra = new DateTime(2011, 5, 21), CaoFK = 3, CriadorFK = 4 },
               new CriadoresCaes { Id = 4, DataCompra = new DateTime(2008, 8, 7), CaoFK = 4, CriadorFK = 5 },
               new CriadoresCaes { Id = 5, DataCompra = new DateTime(2012, 10, 20), CaoFK = 5, CriadorFK = 6 },
               new CriadoresCaes { Id = 6, DataCompra = new DateTime(2010, 11, 30), CaoFK = 6, CriadorFK = 7 },
               new CriadoresCaes { Id = 7, DataCompra = new DateTime(2011, 2, 9), CaoFK = 7, CriadorFK = 8 },
               new CriadoresCaes { Id = 8, DataCompra = new DateTime(2013, 6, 21), CaoFK = 8, CriadorFK = 9 },
               new CriadoresCaes { Id = 9, DataCompra = new DateTime(2011, 7, 9), CaoFK = 9, CriadorFK = 10 },
               new CriadoresCaes { Id = 10, DataCompra = new DateTime(2017, 5, 20), CaoFK = 10, CriadorFK = 5 },
               new CriadoresCaes { Id = 11, DataCompra = new DateTime(2018, 3, 5), CaoFK = 11, CriadorFK = 8 }
            );

        }

        public DbSet<Utilizadores> Utilizadores { get; set; }

        public DbSet<Utilizadores_videos> Utilizadores_videos { get; set; }

        public DbSet<Videos> Videos { get; set; }

        public DbSet<Temporadas> Temporadas { get; set; }

        public DbSet<Episodios> Episodios { get; set; }

    }
}
