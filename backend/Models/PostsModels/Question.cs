using System.ComponentModel.DataAnnotations;

namespace SafeCode.Models
{
    public class Question
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CodeArea { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<UserQuestion> UserQuestions { get; set; }
        public ICollection<QuestionCategory> QuestionCategories { get; set; }

    }
}