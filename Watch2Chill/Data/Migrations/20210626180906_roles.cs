using Microsoft.EntityFrameworkCore.Migrations;

namespace Watch2Chill.Data.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Temporadas_Videos_IdVideo",
                table: "Temporadas");

            migrationBuilder.DropIndex(
                name: "IX_Temporadas_IdVideo",
                table: "Temporadas");

            migrationBuilder.DropColumn(
                name: "IdVideo",
                table: "Temporadas");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a", "f0a26718-30e8-49aa-8f7a-244c347b846b", "Admninistrador", "ADMINISTRADOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "u", "62071bba-d072-4ad6-ad41-1feb544b6751", "Utilizador", "UTILIZADOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Temporadas_IdVideosFK",
                table: "Temporadas",
                column: "IdVideosFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Temporadas_Videos_IdVideosFK",
                table: "Temporadas",
                column: "IdVideosFK",
                principalTable: "Videos",
                principalColumn: "IdVideo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Temporadas_Videos_IdVideosFK",
                table: "Temporadas");

            migrationBuilder.DropIndex(
                name: "IX_Temporadas_IdVideosFK",
                table: "Temporadas");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u");

            migrationBuilder.AddColumn<int>(
                name: "IdVideo",
                table: "Temporadas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Temporadas_IdVideo",
                table: "Temporadas",
                column: "IdVideo");

            migrationBuilder.AddForeignKey(
                name: "FK_Temporadas_Videos_IdVideo",
                table: "Temporadas",
                column: "IdVideo",
                principalTable: "Videos",
                principalColumn: "IdVideo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
