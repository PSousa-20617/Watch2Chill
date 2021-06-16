using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watch2Chill.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Utilizadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Morada = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodPostal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    IdVideo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Elenco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idioma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Realizador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Filme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NTemporadas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.IdVideo);
                });

            migrationBuilder.CreateTable(
                name: "Temporadas",
                columns: table => new
                {
                    IdSerie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumTemps = table.Column<int>(type: "int", nullable: false),
                    NumEps = table.Column<int>(type: "int", nullable: false),
                    DataFim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdVideosFK = table.Column<int>(type: "int", nullable: false),
                    IdVideo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temporadas", x => x.IdSerie);
                    table.ForeignKey(
                        name: "FK_Temporadas_Videos_IdVideo",
                        column: x => x.IdVideo,
                        principalTable: "Videos",
                        principalColumn: "IdVideo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Utilizadores_videos",
                columns: table => new
                {
                    Key = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Utilizadores = table.Column<int>(type: "int", nullable: false),
                    Id1 = table.Column<int>(type: "int", nullable: true),
                    IdVideos = table.Column<int>(type: "int", nullable: false),
                    IdUtilizadorFK = table.Column<int>(type: "int", nullable: false),
                    IdUtilizadorId = table.Column<int>(type: "int", nullable: true),
                    IdVideoFK = table.Column<int>(type: "int", nullable: false),
                    IdVideo1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizadores_videos", x => x.Key);
                    table.ForeignKey(
                        name: "FK_Utilizadores_videos_Utilizadores_Id1",
                        column: x => x.Id1,
                        principalTable: "Utilizadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Utilizadores_videos_Utilizadores_IdUtilizadorId",
                        column: x => x.IdUtilizadorId,
                        principalTable: "Utilizadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Utilizadores_videos_Videos_IdVideo1",
                        column: x => x.IdVideo1,
                        principalTable: "Videos",
                        principalColumn: "IdVideo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Episodios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_serieFK = table.Column<int>(type: "int", nullable: false),
                    Id_serieIdSerie = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episodios_Temporadas_Id_serieIdSerie",
                        column: x => x.Id_serieIdSerie,
                        principalTable: "Temporadas",
                        principalColumn: "IdSerie",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Episodios",
                columns: new[] { "Id", "Foto", "Id_serieFK", "Id_serieIdSerie", "Nome", "Video" },
                values: new object[,]
                {
                    { 1, null, 0, null, "The Godfather", null },
                    { 2, null, 0, null, "The dark Knight", null },
                    { 3, null, 0, null, "The Lord of the Rings", null },
                    { 4, null, 0, null, "Star Wars: Episode I", null },
                    { 5, null, 0, null, "Harry Potter", null },
                    { 6, null, 1, null, "Pilot", null },
                    { 7, null, 1, null, "Winter Is Coming", null },
                    { 8, null, 1, null, "Pilot", null },
                    { 9, null, 1, null, "The Matter Transfer Array", null },
                    { 10, null, 1, null, "Chapter One", null }
                });

            migrationBuilder.InsertData(
                table: "Temporadas",
                columns: new[] { "IdSerie", "DataFim", "IdVideo", "IdVideosFK", "NumEps", "NumTemps" },
                values: new object[,]
                {
                    { 10, "Ainda a decorrer", null, 10, 30, 3 },
                    { 8, "Ainda a decorrer", null, 8, 41, 4 },
                    { 7, "2019", null, 7, 73, 3 },
                    { 6, "2015", null, 6, 62, 5 },
                    { 9, "Ainda a decorrer", null, 9, 16, 2 },
                    { 4, null, null, 4, 1, 0 },
                    { 3, null, null, 3, 1, 0 },
                    { 2, null, null, 2, 1, 0 },
                    { 1, null, null, 1, 1, 0 },
                    { 5, null, null, 5, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Utilizadores",
                columns: new[] { "Id", "CodPostal", "DataNascimento", "Email", "Morada", "Nome", "Sexo" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a@a.a", "Rua do Lago", "Fernando Fernao", "M" },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b@b.b", "Rua da Estrela", "Rodrigo Rodrigues", "M" },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c@c.c", "Rua da Lua", "Gonçalo Gonçalves", "M" },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d@d.d", "Rua do Sol", "Maria Silva", "F" },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e@e.e", "Rua da Ribeira", "Bernardo Alentejo", "M" }
                });

            migrationBuilder.InsertData(
                table: "Utilizadores_videos",
                columns: new[] { "Key", "Id1", "IdUtilizadorFK", "IdUtilizadorId", "IdVideo1", "IdVideoFK", "IdVideos", "Id_Utilizadores" },
                values: new object[,]
                {
                    { 3, null, 0, null, null, 0, 3, 4 },
                    { 2, null, 0, null, null, 0, 2, 3 },
                    { 1, null, 0, null, null, 0, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "IdVideo", "Ano", "Elenco", "Filme", "Foto", "Genero", "Idioma", "NTemporadas", "Nome", "Realizador", "Trailer" },
                values: new object[,]
                {
                    { 9, 2020, "Justin Roiland, Sean Giambrone, Thomas Middleditch", null, null, "Animação, Faroeste, Ficção Científica", "Inglês", 2, "Solar Opposites", "Justin Roiland, Mike McMahan", null },
                    { 1, 1972, "Al Pacino, Marlon Brando, James Caan, Richard S. Castellano", null, null, "Crime, Drama", "Inglês", 0, "The Godfather", "Francis Ford Coppola", null },
                    { 2, 2008, "Christian Bale, Heath Ledger, Aaron Eckhart, Michael Caine", null, null, "Crime, Drama, Ação", "Inglês", 0, "The dark Knight", "Christopher Nolan", null },
                    { 3, 2001, "Alan Howard, Noel Appleby, Sean Astin, Sala Baker", null, null, "Aventura, Fantasia, Drama", "Inglês", 0, "The Lord of the Rings", "Peter Jackson", null },
                    { 4, 1977, "Mark Hamill, Harrison Ford, Carrie Fisher, Peter Cushing", null, null, "Aventura, Ação, Fantasia", "Inglês", 0, "Star Wars: Episode I", "George Lucas", null },
                    { 5, 2001, "Daniel Radcliffe, Rupert Grint, Richard Harris", null, null, "Fantasia, Aventura, Família", "Inglês", 0, "Harry Potter", "Chris Columbus", null },
                    { 6, 2008, "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris", null, null, "Drama, Crime, Thriller", "Inglês", 5, "Breaking Bad", "Vince Gilligan", null },
                    { 7, 2011, " Emilia Clarke, Peter Dinklage, Lena Headey, Peter Dinklage, Kit Harington", null, null, "Aventura, Drama, Fantasia", "Inglês", 8, "Game of Thrones", "D.B. Weiss, David Benioff", null },
                    { 8, 2013, "Justin Roiland, Chris Parnell, Spencer Grammer, Sarah Chalke", null, null, "Animação, Aventura, Comédia", "Inglês", 41, "Rick and Morty", "Dan Harmon, Justin Roiland", null },
                    { 10, 2018, "Olan Rogers, Fred Armisen, David Tennant", null, null, "Animação, Aventura, Comédia", "Inglês", 3, "Final Space", "Olan Rogers", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Episodios_Id_serieIdSerie",
                table: "Episodios",
                column: "Id_serieIdSerie");

            migrationBuilder.CreateIndex(
                name: "IX_Temporadas_IdVideo",
                table: "Temporadas",
                column: "IdVideo");

            migrationBuilder.CreateIndex(
                name: "IX_Utilizadores_videos_Id1",
                table: "Utilizadores_videos",
                column: "Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Utilizadores_videos_IdUtilizadorId",
                table: "Utilizadores_videos",
                column: "IdUtilizadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Utilizadores_videos_IdVideo1",
                table: "Utilizadores_videos",
                column: "IdVideo1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Episodios");

            migrationBuilder.DropTable(
                name: "Utilizadores_videos");

            migrationBuilder.DropTable(
                name: "Temporadas");

            migrationBuilder.DropTable(
                name: "Utilizadores");

            migrationBuilder.DropTable(
                name: "Videos");
        }
    }
}
