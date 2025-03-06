using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace UKW_sklep_czw.Models
{
	public class Category
	{
		//[Key]
		//public int KategoriaId { get; set; }

		public int CategoryId { get; set; }

		[Required(ErrorMessage = "Wpisz nazwę")]
		public string Name { get; set; }

		[StringLength(600, ErrorMessage = "Przekroczono limit znaków")]
		public string Desc { get; set; }

		public ICollection<Film> Films { get; set; }	
	}
}
