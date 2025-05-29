using System.ComponentModel.DataAnnotations;

namespace UKW_sklep_czw.Models.Users
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Musisz wprowadzić nazwę użytkownika")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Musisz wprowadzić hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
