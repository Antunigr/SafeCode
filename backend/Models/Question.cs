using System.ComponentModel.DataAnnotations;

namespace SafeCode.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public string User { get; set; } // trocar string for userModel
        public string Title { get; set; }
        public string Description { get; set; }
        public string CodeArea { get; set; }

        public IList<QuestionCategories> QuestionCategories { get; set; }
    }
}