using System.ComponentModel.DataAnnotations;

namespace SafeCode.Models
{
    public class Comment
    {
        [Required]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string? Text { get; set; }
        public DateTime CreationDate { get; set; }
        public string QuestionId { get; set; }
        public Question Question { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public string? ParentCommentId { get; set; }
        public Comment ParentComment { get; set; }
        public ICollection<Comment> ChildrenComments { get; set; }

    }

}