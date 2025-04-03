using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UKW_sklep_czw.Migrations
{
    public partial class poprawka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 15,
                column: "Poster",
                value: "poster15.webp");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 15,
                column: "Poster",
                value: "poster15.jpg");
        }
    }
}
