using Microsoft.EntityFrameworkCore.Migrations;

namespace Watch2Chill.Migrations
{
    public partial class utilizadoresVideos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                column: "ConcurrencyStamp",
                value: "e5bffc94-97b1-4752-8b27-58a524c19732");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u",
                column: "ConcurrencyStamp",
                value: "51c900a3-8182-4272-a394-cfdb2da24d9a");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
