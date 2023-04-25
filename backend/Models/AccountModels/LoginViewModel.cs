using System.ComponentModel.DataAnnotations;

namespace SafeCode.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O Email é obrigatório")]
        // [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatória")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}