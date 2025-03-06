using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UKW_sklep_czw.Migrations
{
    public partial class DaneStartowe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Desc", "Name" },
                values: new object[,]
                {
                    { 1, "Filmy pełne dynamicznych scen i efektów specjalnych.", "Akcja" },
                    { 2, "Filmy dostarczające dużą dawkę humoru i rozrywki.", "Komedia" },
                    { 3, "Filmy o poważnej tematyce, często poruszające trudne tematy.", "Dramat" },
                    { 4, "Filmy mające na celu wywołanie strachu i napięcia.", "Horror" },
                    { 5, "Filmy opowiadające o przyszłości, technologii i kosmosie.", "Sci-Fi" },
                    { 6, "Filmy osadzone w magicznych światach, pełne nadprzyrodzonych zjawisk.", "Fantasy" },
                    { 7, "Filmy pełne napięcia, zagadek i zwrotów akcji.", "Thriller" },
                    { 8, "Filmy animowane, często skierowane do dzieci i rodzin.", "Animacja" },
                    { 9, "Filmy przedstawiające prawdziwe wydarzenia i historie.", "Dokument" },
                    { 10, "Filmy, w których ważnym elementem są piosenki i taniec.", "Musical" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "CategoryId", "Description", "Director", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Postapokaliptyczna walka o przetrwanie.", "George Miller", 29.99m, "Mad Max: Na drodze gniewu" },
                    { 2, 2, "Niepoprawny komediowy antybohater.", "Tim Miller", 24.99m, "Deadpool" },
                    { 3, 3, "Historia niezwykłego człowieka o wielkim sercu.", "Robert Zemeckis", 19.99m, "Forrest Gump" },
                    { 4, 4, "Przerażająca historia hotelu i jego mieszkańców.", "Stanley Kubrick", 22.99m, "Lśnienie" },
                    { 5, 5, "Podróż w nieznane w poszukiwaniu nowego domu.", "Christopher Nolan", 34.99m, "Interstellar" },
                    { 6, 6, "Początek epickiej przygody w Śródziemiu.", "Peter Jackson", 39.99m, "Władca Pierścieni: Drużyna Pierścienia" },
                    { 7, 7, "Mroczny thriller pełen zwrotów akcji.", "David Fincher", 26.99m, "Zaginiona dziewczyna" },
                    { 8, 8, "Magiczna opowieść o sile siostrzanej miłości.", "Chris Buck, Jennifer Lee", 19.99m, "Kraina Lodu" },
                    { 9, 9, "Dokument o systemowym rasizmie w USA.", "Ava DuVernay", 14.99m, "13th" },
                    { 10, 10, "Muzyczna opowieść o miłości i marzeniach.", "Damien Chazelle", 29.99m, "La La Land" },
                    { 11, 1, "Zemsta na najwyższym poziomie.", "Chad Stahelski", 27.99m, "John Wick" },
                    { 12, 2, "Zwariowana komedia o nieprzewidywalnej imprezie.", "Todd Phillips", 21.99m, "Kac Vegas" },
                    { 13, 3, "Epicka historia honoru i zemsty.", "Ridley Scott", 31.99m, "Gladiator" },
                    { 14, 4, "Paranormalne śledztwo na farmie.", "James Wan", 18.99m, "Obecność" },
                    { 15, 5, "Kultowy cyberpunkowy świat.", "Denis Villeneuve", 32.99m, "Blade Runner 2049" },
                    { 16, 6, "Początek przygód młodego czarodzieja.", "Chris Columbus", 24.99m, "Harry Potter i Kamień Filozoficzny" },
                    { 17, 7, "Psychopatyczny morderca i jego makabryczna gra.", "David Fincher", 28.99m, "Siedem" },
                    { 18, 8, "Przygody zabawek, które żyją własnym życiem.", "John Lasseter", 20.99m, "Toy Story" },
                    { 19, 9, "Dokument o pierwszym lądowaniu na Księżycu.", "Todd Douglas Miller", 17.99m, "Człowiek na Księżycu" },
                    { 20, 10, "Musical pełen hitów ABBY.", "Phyllida Lloyd", 23.99m, "Mamma Mia!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);
        }
    }
}
