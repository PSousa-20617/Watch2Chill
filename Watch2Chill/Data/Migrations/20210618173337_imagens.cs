using Microsoft.EntityFrameworkCore.Migrations;

namespace Watch2Chill.Data.Migrations
{
    public partial class imagens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 1,
                column: "Foto",
                value: "TheGodfather.jpg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 2,
                column: "Foto",
                value: "TheDarkKnight.jpg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 3,
                column: "Foto",
                value: "TheLordOfTheRings.jpg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 4,
                column: "Foto",
                value: "StarWars.jpg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 5,
                column: "Foto",
                value: "HarryPotter.jpg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 6,
                column: "Foto",
                value: "BreakingBad.jpg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 7,
                column: "Foto",
                value: "GameOfThrones.jpg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 8,
                column: "Foto",
                value: "RickMorty.jpg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 9,
                column: "Foto",
                value: "solarOpposites.jpg");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 10,
                column: "Foto",
                value: "FinalSpace.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 1,
                column: "Foto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 2,
                column: "Foto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 3,
                column: "Foto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 4,
                column: "Foto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 5,
                column: "Foto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 6,
                column: "Foto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 7,
                column: "Foto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 8,
                column: "Foto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 9,
                column: "Foto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 10,
                column: "Foto",
                value: null);
        }
    }
}
