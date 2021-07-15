using Microsoft.EntityFrameworkCore.Migrations;

namespace Watch2Chill.Migrations
{
    public partial class trailerFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a",
                column: "ConcurrencyStamp",
                value: "13dd79ea-a319-4482-9957-5b5cc18200a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "u",
                column: "ConcurrencyStamp",
                value: "cb11374d-bd2c-4532-98f3-25908be95778");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 2,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=EXeTwQWrcwY");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 3,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=V75dMMIW2B4");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 4,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=bD7bpG-zDJQ");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 5,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=VyHV0BRtdxo");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 6,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=HhesaQXLuRY");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 7,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=gcTkNV5Vg1E");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 8,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=Uz2m4T_JNIs");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 9,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=UN7OH4d3CEw");

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 10,
                column: "Trailer",
                value: "https://www.youtube.com/watch?v=fkyNpNysdZw");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 2,
                column: "Trailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 3,
                column: "Trailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 4,
                column: "Trailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 5,
                column: "Trailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 6,
                column: "Trailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 7,
                column: "Trailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 8,
                column: "Trailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 9,
                column: "Trailer",
                value: null);

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "IdVideo",
                keyValue: 10,
                column: "Trailer",
                value: null);
        }
    }
}
