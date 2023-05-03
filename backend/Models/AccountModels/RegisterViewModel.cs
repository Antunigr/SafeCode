using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace SafeCode.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [MaxLength(30, ErrorMessage = "Limite de caracteres ultrapassado"), MinLength(2, ErrorMessage = "Seu nome precisa ter mais de dois caracteres")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "O Email é obrigatório")]
        [MaxLength(30, ErrorMessage = "Limite de caracteres ultrapassado"), MinLength(2, ErrorMessage = "Seu email precisa ter mais de dois caracteres")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatoria")]
        [MaxLength(30, ErrorMessage = "Limite de caracteres ultrapassado"), MinLength(4, ErrorMessage = "Sua senha precisa ter mais que quatro caracteres")]
        [DataType(DataType.Password, ErrorMessage = "Senha invalida")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirme sua senha")]
        [MaxLength(30, ErrorMessage = "Limite de caracteres ultrapassado"), MinLength(4, ErrorMessage = "Sua senha precisa ter mais que quatro caracteres")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "As senhas não coferem")]
        public string? ConfirmPassword { get; set; }

        [NotMapped]
        public string? UserQId { get; set; } = Guid.NewGuid().ToString();

    }
}