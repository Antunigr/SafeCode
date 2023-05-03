using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SafeCode.Models
{
    public class Question
    {
        [Required]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required(ErrorMessage = "Você precisa adicionar um titulo")]
        [MaxLength(160, ErrorMessage = "Limite de caracteres ultrapassado"), MinLength(2, ErrorMessage = "Seu titulo precisa ter mais de dois caracteres")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Por favor, adicione uma descrição")]
        [MaxLength(160, ErrorMessage = "Limite de caracteres ultrapassado"), MinLength(2, ErrorMessage = "Sua descrição precisa ter mais de dois caracteres")]
        public string? Description { get; set; }

        [NotMapped]
        public string? CodeArea { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<UserQuestion>? UserQuestions { get; set; }

        public int CategoriesId { get; set; }
        public Categories? Categories { get; set; }

    }
}