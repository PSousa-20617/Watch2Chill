using Microsoft.EntityFrameworkCore.Migrations;

namespace Watch2Chill.Migrations
{
    public partial class trailer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                column: "ConcurrencyStamp",
                value: "235263ce-2311-42c2-bc9f-05a323049185");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u",
                column: "ConcurrencyStamp",
                value: "8aff14fc-3835-462a-8885-8585f82794e3");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 1,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=sY1S34973zA");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                column: "ConcurrencyStamp",
                value: "d82f9b21-64e6-400b-8b28-7c06f3440022");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u",
                column: "ConcurrencyStamp",
                value: "d235cc7b-4f77-4f05-b139-db276fa5fa65");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 1,
                column: "Trailer",
                value: null);
        }
    }
}
