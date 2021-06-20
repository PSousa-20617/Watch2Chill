using Microsoft.EntityFrameworkCore.Migrations;

namespace Watch2Chill.Data.Migrations
{
    public partial class temporadasController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 6,
                column: "Data",
                value: "2015");

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 7,
                column: "Data",
                value: "2019");

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 8,
                column: "Data",
                value: "Ainda a decorrer");

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 9,
                column: "Data",
                value: "Ainda a decorrer");

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 10,
                column: "Data",
                value: "Ainda a decorrer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 6,
                column: "Data",
                value: null);

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 7,
                column: "Data",
                value: null);

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 8,
                column: "Data",
                value: null);

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 9,
                column: "Data",
                value: null);

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 10,
                column: "Data",
                value: null);
        }
    }
}
