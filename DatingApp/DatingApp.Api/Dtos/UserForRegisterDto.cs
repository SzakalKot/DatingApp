using System.ComponentModel.DataAnnotations;

namespace DatingApp.Api.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage="Hasło musi mieć przynajmniej 4 litery ")]
        public string Password { get; set; }
    }
}