using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos.User
{
    public class LoginDto
    {
        [Required(ErrorMessage = "O e-mail é um campo obrigatório para Login.")]
        [EmailAddress(ErrorMessage = "O e-mail está em um formato inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é um campo obrigatório para Login.")]
        public string Password { get; set; }
    }
}
