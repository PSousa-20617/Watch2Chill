using Microsoft.EntityFrameworkCore.Migrations;

namespace Watch2Chill.Migrations
{
    public partial class begin_fixAtribs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Utilizadores",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "CodPostal",
                table: "Utilizadores",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CodPostal",
                value: "2313-231");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CodPostal",
                value: "3100-121");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 3,
                column: "CodPostal",
                value: "3152-344");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 4,
                column: "CodPostal",
                value: "1222-783");

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 5,
                column: "CodPostal",
                value: "1284-231");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Utilizadores",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CodPostal",
                table: "Utilizadores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 1,
                column: "CodPostal",
                value: null);

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 2,
                column: "CodPostal",
                value: null);

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 3,
                column: "CodPostal",
                value: null);

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 4,
                column: "CodPostal",
                value: null);

            migrationBuilder.UpdateData(
                table: "Utilizadores",
                keyColumn: "Id",
                keyValue: 5,
                column: "CodPostal",
                value: null);
        }
    }
}
