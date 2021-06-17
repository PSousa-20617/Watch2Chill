using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watch2Chill.Migrations
{
    public partial class begin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "UtilizadoresVideos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUtilizadorFK = table.Column<int>(type: "int", nullable: false),
                    IdVideoFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilizadoresVideos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UtilizadoresVideos_Utilizadores_IdUtilizadorFK",
                        column: x => x.IdUtilizadorFK,
                        principalTable: "Utilizadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UtilizadoresVideos_Videos_IdVideoFK",
                        column: x => x.IdVideoFK,
                        principalTable: "Videos",
                        principalColumn: "IdVideo",
                        onDelete: ReferentialAction.Cascade);
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
                    { 9, "Ainda a decorrer", null, 9, 16, 2 },
                    { 7, "2019", null, 7, 73, 3 },
                    { 6, "2015", null, 6, 62, 5 },
                    { 8, "Ainda a decorrer", null, 8, 41, 4 },
                    { 4, null, null, 4, 1, 0 },
                    { 3, null, null, 3, 1, 0 },
                    { 5, null, null, 5, 1, 0 },
                    { 2, null, null, 2, 1, 0 },
                    { 1, null, null, 1, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "Utilizadores",
                columns: new[] { "Id", "CodPostal", "DataNascimento", "Email", "Morada", "Nome", "Sexo" },
                values: new object[,]
                {
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "d@d.d", "Rua do Sol", "Maria Silva", "F" },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c@c.c", "Rua da Lua", "Gonçalo Gonçalves", "M" },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "e@e.e", "Rua da Ribeira", "Bernardo Alentejo", "M" },
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "a@a.a", "Rua do Lago", "Fernando Fernao", "M" },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "b@b.b", "Rua da Estrela", "Rodrigo Rodrigues", "M" }
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

            migrationBuilder.InsertData(
                table: "UtilizadoresVideos",
                columns: new[] { "Id", "IdUtilizadorFK", "IdVideoFK" },
                values: new object[] { 1, 2, 1 });

            migrationBuilder.InsertData(
                table: "UtilizadoresVideos",
                columns: new[] { "Id", "IdUtilizadorFK", "IdVideoFK" },
                values: new object[] { 2, 3, 2 });

            migrationBuilder.InsertData(
                table: "UtilizadoresVideos",
                columns: new[] { "Id", "IdUtilizadorFK", "IdVideoFK" },
                values: new object[] { 3, 4, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Episodios_Id_serieIdSerie",
                table: "Episodios",
                column: "Id_serieIdSerie");

            migrationBuilder.CreateIndex(
                name: "IX_Temporadas_IdVideo",
                table: "Temporadas",
                column: "IdVideo");

            migrationBuilder.CreateIndex(
                name: "IX_UtilizadoresVideos_IdUtilizadorFK",
                table: "UtilizadoresVideos",
                column: "IdUtilizadorFK");

            migrationBuilder.CreateIndex(
                name: "IX_UtilizadoresVideos_IdVideoFK",
                table: "UtilizadoresVideos",
                column: "IdVideoFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Episodios");

            migrationBuilder.DropTable(
                name: "UtilizadoresVideos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Temporadas");

            migrationBuilder.DropTable(
                name: "Utilizadores");

            migrationBuilder.DropTable(
                name: "Videos");
        }
    }
}
