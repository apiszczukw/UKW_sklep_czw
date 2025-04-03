using Microsoft.EntityFrameworkCore;
using UKW_sklep_czw.Models;

namespace UKW_sklep_czw.DAL
{
	public class FilmsContext : DbContext
	{
		public DbSet<Film> Films { get; set; }

		public DbSet<Category> Categories { get; set; }

		public FilmsContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			var categories = new List<Category>()
			{
				 new Category { CategoryId = 1, Name = "Akcja", Desc = "Filmy pełne dynamicznych scen i efektów specjalnych." },
			new Category { CategoryId = 2, Name = "Komedia", Desc = "Filmy dostarczające dużą dawkę humoru i rozrywki." },
			new Category { CategoryId = 3, Name = "Dramat", Desc = "Filmy o poważnej tematyce, często poruszające trudne tematy." },
			new Category { CategoryId = 4, Name = "Horror", Desc = "Filmy mające na celu wywołanie strachu i napięcia." },
			new Category { CategoryId = 5, Name = "Sci-Fi", Desc = "Filmy opowiadające o przyszłości, technologii i kosmosie." },
			new Category { CategoryId = 6, Name = "Fantasy", Desc = "Filmy osadzone w magicznych światach, pełne nadprzyrodzonych zjawisk." },
			new Category { CategoryId = 7, Name = "Thriller", Desc = "Filmy pełne napięcia, zagadek i zwrotów akcji." },
			new Category { CategoryId = 8, Name = "Animacja", Desc = "Filmy animowane, często skierowane do dzieci i rodzin." },
			new Category { CategoryId = 9, Name = "Dokument", Desc = "Filmy przedstawiające prawdziwe wydarzenia i historie." },
			new Category { CategoryId = 10, Name = "Musical", Desc = "Filmy, w których ważnym elementem są piosenki i taniec." }
			};

			var films = new List<Film>()
			{
			new Film { Poster="poster1.jpg", FilmId = 1, Title = "Mad Max: Na drodze gniewu", Director = "George Miller", Description = "Postapokaliptyczna walka o przetrwanie.", Price = 29.99m, CategoryId = 1 },
			new Film { Poster="poster2.jpg", FilmId = 2, Title = "Deadpool", Director = "Tim Miller", Description = "Niepoprawny komediowy antybohater.", Price = 24.99m, CategoryId = 2 },
			new Film { Poster="poster3.webp", FilmId = 3, Title = "Forrest Gump", Director = "Robert Zemeckis", Description = "Historia niezwykłego człowieka o wielkim sercu.", Price = 19.99m, CategoryId = 3 },
			new Film { Poster="poster4.jpg", FilmId = 4, Title = "Lśnienie", Director = "Stanley Kubrick", Description = "Przerażająca historia hotelu i jego mieszkańców.", Price = 22.99m, CategoryId = 4 },
			new Film { Poster="poster5.webp", FilmId = 5, Title = "Interstellar", Director = "Christopher Nolan", Description = "Podróż w nieznane w poszukiwaniu nowego domu.", Price = 34.99m, CategoryId = 5 },
			new Film { Poster="poster6.jpg", FilmId = 6, Title = "Władca Pierścieni: Drużyna Pierścienia", Director = "Peter Jackson", Description = "Początek epickiej przygody w Śródziemiu.", Price = 39.99m, CategoryId = 6 },	   
			new Film { Poster="poster7.jpg", FilmId = 7, Title = "Zaginiona dziewczyna", Director = "David Fincher", Description = "Mroczny thriller pełen zwrotów akcji.", Price = 26.99m, CategoryId = 7 },
			new Film { Poster="poster8.jpg", FilmId = 8, Title = "Kraina Lodu", Director = "Chris Buck, Jennifer Lee", Description = "Magiczna opowieść o sile siostrzanej miłości.", Price = 19.99m, CategoryId = 8 },
			new Film { Poster="poster9.jpg", FilmId = 9, Title = "13th", Director = "Ava DuVernay", Description = "Dokument o systemowym rasizmie w USA.", Price = 14.99m, CategoryId = 9 },
			new Film { Poster="poster10.webp", FilmId = 10, Title = "La La Land", Director = "Damien Chazelle", Description = "Muzyczna opowieść o miłości i marzeniach.", Price = 29.99m, CategoryId = 10 },
			new Film { Poster="poster11.webp", FilmId = 11, Title = "John Wick", Director = "Chad Stahelski", Description = "Zemsta na najwyższym poziomie.", Price = 27.99m, CategoryId = 1 },
			new Film { Poster="poster12.jpg", FilmId = 12, Title = "Kac Vegas", Director = "Todd Phillips", Description = "Zwariowana komedia o nieprzewidywalnej imprezie.", Price = 21.99m, CategoryId = 2 },
			new Film { Poster="poster13.webp", FilmId = 13, Title = "Gladiator", Director = "Ridley Scott", Description = "Epicka historia honoru i zemsty.", Price = 31.99m, CategoryId = 3 },
			new Film { Poster="poster14.jpg", FilmId = 14, Title = "Obecność", Director = "James Wan", Description = "Paranormalne śledztwo na farmie.", Price = 18.99m, CategoryId = 4 },
			new Film { Poster="poster15.webp", FilmId = 15, Title = "Blade Runner 2049", Director = "Denis Villeneuve", Description = "Kultowy cyberpunkowy świat.", Price = 32.99m, CategoryId = 5 },
			new Film { Poster="poster16.jpg", FilmId = 16, Title = "Harry Potter i Kamień Filozoficzny", Director = "Chris Columbus", Description = "Początek przygód młodego czarodzieja.", Price = 24.99m, CategoryId = 6 },			
			new Film { Poster="poster17.jpg", FilmId = 17, Title = "Siedem", Director = "David Fincher", Description = "Psychopatyczny morderca i jego makabryczna gra.", Price = 28.99m, CategoryId = 7 },
			new Film { Poster="poster18.webp", FilmId = 18, Title = "Toy Story", Director = "John Lasseter", Description = "Przygody zabawek, które żyją własnym życiem.", Price = 20.99m, CategoryId = 8 },
			new Film { Poster="poster19.jpg", FilmId = 19, Title = "Człowiek na Księżycu", Director = "Todd Douglas Miller", Description = "Dokument o pierwszym lądowaniu na Księżycu.", Price = 17.99m, CategoryId = 9 },
			new Film { Poster="poster20.jpg", FilmId = 20, Title = "Mamma Mia!", Director = "Phyllida Lloyd", Description = "Musical pełen hitów ABBY.", Price = 23.99m, CategoryId = 10 }
			};

			modelBuilder.Entity<Category>().HasData(categories);
			modelBuilder.Entity<Film>().HasData(films);
		}
	}
}
