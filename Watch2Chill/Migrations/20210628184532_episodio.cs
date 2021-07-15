using Microsoft.EntityFrameworkCore.Migrations;

namespace Watch2Chill.Migrations
{
    public partial class episodio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                column: "ConcurrencyStamp",
                value: "f2e3904a-771f-4f43-9cf0-e19635ad729d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u",
                column: "ConcurrencyStamp",
                value: "4c7f3063-c9ca-406a-8dd1-d6f70128ebfe");

            migrationBuilder.UpdateData(
                table: "Episodios",
                keyColumn: "Id",
                keyValue: 8,
                column: "Video",
                value: "Pilot.mp4");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 8,
                column: "Filme",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                column: "ConcurrencyStamp",
                value: "05161505-284a-430f-9c1b-a4195271a2f0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u",
                column: "ConcurrencyStamp",
                value: "7d25efa7-b571-44f2-a0ee-bbf9cec6ab90");

            migrationBuilder.UpdateData(
                table: "Episodios",
                keyColumn: "Id",
                keyValue: 8,
                column: "Video",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 8,
                column: "Filme",
                value: "Pilot.mp4");
        }
    }
}
