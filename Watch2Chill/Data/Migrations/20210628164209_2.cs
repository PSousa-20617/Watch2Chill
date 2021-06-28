using Microsoft.EntityFrameworkCore.Migrations;

namespace Watch2Chill.Data.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                column: "ConcurrencyStamp",
                value: "a5b48c89-87d2-4abc-9410-d35d174ee496");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u",
                column: "ConcurrencyStamp",
                value: "b6435ec1-6f90-4649-9518-b7a28db37195");

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 1,
                column: "Data",
                value: "");

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 2,
                column: "Data",
                value: "");

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 3,
                column: "Data",
                value: "");

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 4,
                column: "Data",
                value: "");

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 5,
                column: "Data",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                column: "ConcurrencyStamp",
                value: "970dc446-3ccc-417c-a44e-6b11e910b7c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u",
                column: "ConcurrencyStamp",
                value: "5e52f080-0936-4bc0-ac1f-7552ea683527");

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 1,
                column: "Data",
                value: null);

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 2,
                column: "Data",
                value: null);

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 3,
                column: "Data",
                value: null);

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 4,
                column: "Data",
                value: null);

            migrationBuilder.UpdateData(
                table: "Temporadas",
                keyColumn: "IdSerie",
                keyValue: 5,
                column: "Data",
                value: null);
        }
    }
}
