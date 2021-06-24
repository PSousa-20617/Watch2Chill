using Microsoft.EntityFrameworkCore.Migrations;

namespace Watch2Chill.Data.Migrations
{
    public partial class ntemp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 8,
                column: "NTemporadas",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 8,
                column: "NTemporadas",
                value: 41);
        }
    }
}
