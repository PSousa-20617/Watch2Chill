using Microsoft.EntityFrameworkCore.Migrations;

namespace Watch2Chill.Migrations
{
    public partial class useriddelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                column: "ConcurrencyStamp",
                value: "c2d76a39-8597-4c9b-b0d3-2f31a379aa08");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u",
                column: "ConcurrencyStamp",
                value: "05de0da7-b80a-46ee-b814-a74cbf1448cb");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                column: "ConcurrencyStamp",
                value: "81576801-cfce-43e9-a958-a28b22e01611");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u",
                column: "ConcurrencyStamp",
                value: "7078d42d-1f95-411c-961d-1098a39d120e");
        }
    }
}
