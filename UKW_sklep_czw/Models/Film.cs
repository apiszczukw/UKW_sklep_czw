using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UKW_sklep_czw.Models
{
	public class Film
	{
		public int FilmId { get; set; }

		[Required(ErrorMessage = "Podaj tytuł")]
		public string Title { get; set; }

		public string Director { get; set; }

		[StringLength(600, ErrorMessage = "Przekroczono limit znaków")]
		public string Description { get; set; }

		public decimal? Price { get; set; }

		public int CategoryId { get; set; }
		//public int CategoryCategoryId { get; set; }

		//[ForeignKey("Category")]
		//public int KategoriaId { get; set; }

		public Category Category { get; set; }
	}
}
