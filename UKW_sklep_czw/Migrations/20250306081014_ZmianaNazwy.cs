using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UKW_sklep_czw.Migrations
{
    public partial class ZmianaNazwy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "Films",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Films",
                newName: "Desc");
        }
    }
}
