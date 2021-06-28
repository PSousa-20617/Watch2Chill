using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watch2Chill.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a", "d82f9b21-64e6-400b-8b28-7c06f3440022", "Admninistrador", "ADMINISTRADOR" },
                    { "u", "d235cc7b-4f77-4f05-b139-db276fa5fa65", "Utilizador", "UTILIZADOR" }
                });

            migrationBuilder.InsertData(
                table: "Episodios",
                columns: new[] { "Id", "Foto", "Id_serieFK", "Id_serieIdSerie", "Nome", "Video" },
                values: new object[,]
                {
                    { 9, null, 1, null, "The Matter Transfer Array", null },
                    { 8, null, 1, null, "Pilot", null },
                    { 7, null, 1, null, "Winter Is Coming", null },
                    { 6, null, 1, null, "Pilot", null },
                    { 10, null, 1, null, "Chapter One", null },
                    { 4, null, 0, null, "Star Wars: Episode I", null },
                    { 3, null, 0, null, "The Lord of the Rings", null },
                    { 2, null, 0, null, "The dark Knight", null },
                    { 1, null, 0, null, "The Godfather", null },
                    { 5, null, 0, null, "Harry Potter", null }
                });

            migrationBuilder.InsertData(
                table: "Utilizadores",
                columns: new[] { "Id", "CodPostal", "DataNascimento", "Email", "Morada", "Nome", "Sexo", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin1@admin1.com", "Rua da Lua", "Administrador", "M", "3d934ae8-b06a-40af-9037-ab0c50f1ead0", "3d934ae8-b06a-40af-9037-ab0c50f1ead0" },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "utilizador@utilizador.com", "Rua da Lua", "Utilizador", "M", "9e2e24bf-9156-4caa-9f03-af7e1602d545", "9e2e24bf-9156-4caa-9f03-af7e1602d545" }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "IdVideo", "Ano", "Elenco", "Filme", "Foto", "Genero", "Idioma", "NTemporadas", "Nome", "Realizador", "Trailer" },
                values: new object[,]
                {
                    { 8, 2013, "Justin Roiland, Chris Parnell, Spencer Grammer, Sarah Chalke", null, "RickMorty.jpg", "Animação, Aventura, Comédia", "Inglês", 4, "Rick and Morty", "Dan Harmon, Justin Roiland", null },
                    { 7, 2011, " Emilia Clarke, Peter Dinklage, Lena Headey, Peter Dinklage, Kit Harington", null, "GameOfThrones.jpg", "Aventura, Drama, Fantasia", "Inglês", 8, "Game of Thrones", "D.B. Weiss, David Benioff", null },
                    { 6, 2008, "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris", null, "BreakingBad.jpg", "Drama, Crime, Thriller", "Inglês", 5, "Breaking Bad", "Vince Gilligan", null },
                    { 5, 2001, "Daniel Radcliffe, Rupert Grint, Richard Harris", null, "HarryPotter.jpg", "Fantasia, Aventura, Família", "Inglês", 0, "Harry Potter", "Chris Columbus", null },
                    { 2, 2008, "Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine", null, "TheDarkKnight.jpg", "Crime, Drama, Ação", "Inglês", 0, "The dark Knight", "Christopher Nolan", null },
                    { 3, 2001, "Alan Howard, Noel Appleby, Sean Astin, Sala Baker", null, "TheLordOfTheRings.jpg", "Aventura, Fantasia, Drama", "Inglês", 0, "The Lord of the Rings", "Peter Jackson", null },
                    { 1, 1972, "Al Pacino, Marlon Brando, James Caan, Richard S. Castellano", null, "TheGodfather.jpg", "Crime, Drama", "Inglês", 0, "The Godfather", "Francis Ford Coppola", null },
                    { 9, 2020, "Justin Roiland, Sean Giambrone, Thomas Middleditch", null, "solarOpposites.jpg", "Animação, Faroeste, Ficção Científica", "Inglês", 2, "Solar Opposites", "Justin Roiland, Mike McMahan", null },
                    { 4, 1977, "Mark Hamill, Harrison Ford, Carrie Fisher, Peter Cushing", null, "StarWars.jpg", "Aventura, Ação, Fantasia", "Inglês", 0, "Star Wars: Episode I", "George Lucas", null },
                    { 10, 2018, "Olan Rogers, Fred Armisen, David Tennant", null, "FinalSpace.jpg", "Animação, Aventura, Comédia", "Inglês", 3, "Final Space", "Olan Rogers", null }
                });

            migrationBuilder.InsertData(
                table: "Temporadas",
                columns: new[] { "IdSerie", "Data", "IdVideosFK", "NumEps", "NumTemps" },
                values: new object[,]
                {
                    { 1, "", 1, 1, 0 },
                    { 2, "", 2, 1, 0 },
                    { 3, "", 3, 1, 0 },
                    { 4, "", 4, 1, 0 },
                    { 5, "", 5, 1, 0 },
                    { 6, "2015", 6, 62, 5 },
                    { 7, "2019", 7, 73, 3 },
                    { 8, "Ainda a decorrer", 8, 41, 4 },
                    { 9, "Ainda a decorrer", 9, 16, 2 },
                    { 10, "Ainda a decorrer", 10, 30, 3 }
                });

            migrationBuilder.InsertData(
                table: "UtilizadoresVideos",
                columns: new[] { "Id", "IdUtilizadorFK", "IdVideoFK" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u");

            migrationBuilder.DeleteData(
                table: "Episodios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Episodios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Episodios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Episodios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Episodios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Episodios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Episodios",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Episodios",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Episodios",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Episodios",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UtilizadoresVideos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UtilizadoresVideos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 10);
        }
    }
}
