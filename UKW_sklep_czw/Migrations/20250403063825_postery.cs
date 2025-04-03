using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UKW_sklep_czw.Migrations
{
    public partial class postery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Poster",
                table: "Films",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1,
                column: "Poster",
                value: "poster1.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2,
                column: "Poster",
                value: "poster2.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3,
                column: "Poster",
                value: "poster3.webp");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 4,
                column: "Poster",
                value: "poster4.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 5,
                column: "Poster",
                value: "poster5.webp");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 6,
                column: "Poster",
                value: "poster6.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 7,
                column: "Poster",
                value: "poster7.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 8,
                column: "Poster",
                value: "poster8.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 9,
                column: "Poster",
                value: "poster9.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 10,
                column: "Poster",
                value: "poster10.webp");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 11,
                column: "Poster",
                value: "poster11.webp");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 12,
                column: "Poster",
                value: "poster12.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 13,
                column: "Poster",
                value: "poster13.webp");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 14,
                column: "Poster",
                value: "poster14.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 15,
                column: "Poster",
                value: "poster15.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 16,
                column: "Poster",
                value: "poster16.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 17,
                column: "Poster",
                value: "poster17.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 18,
                column: "Poster",
                value: "poster18.webp");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 19,
                column: "Poster",
                value: "poster19.jpg");

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 20,
                column: "Poster",
                value: "poster20.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Poster",
                table: "Films");
        }
    }
}
