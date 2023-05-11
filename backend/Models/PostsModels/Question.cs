using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SafeCode.Models
{
    public class Question
    {
        [Required]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required(ErrorMessage = "Você precisa adicionar um titulo")]
        [MaxLength(260, ErrorMessage = "Limite de caracteres ultrapassado"), MinLength(2, ErrorMessage = "Seu titulo precisa ter mais de dois caracteres")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Por favor, adicione uma descrição")]
        [MaxLength(560, ErrorMessage = "Limite de caracteres ultrapassado"), MinLength(2, ErrorMessage = "Sua descrição precisa ter mais de dois caracteres")]
        public string? Description { get; set; }

        public string? CodeArea { get; set; }
        public DateTime CreationDate { get; set; }
        public int CategoriesId { get; set; }
        public Categories? Categories { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public ICollection<ApplicationUser>? IpplicationUser { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}