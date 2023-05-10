using System.ComponentModel.DataAnnotations;

namespace SafeCode.Models
{
    public class Comment
    {
        [Required]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required(ErrorMessage = "Você precisa adicionar um comentário")]
        [MaxLength(1000, ErrorMessage = "Limite de caracteres ultrapassado"), MinLength(2, ErrorMessage = "Seu comentário precisa ter mais de dois caracteres")]
        public string? Text { get; set; }

        public DateTime CreationDate { get; set; }

        public string QuestionId { get; set; }
        public Question Question { get; set; }

        public string? ParentCommentId { get; set; }
        public Comment ParentComment { get; set; }

        public ICollection<Comment> ChildrenComments { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
    }
}
