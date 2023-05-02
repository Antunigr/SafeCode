using System.ComponentModel.DataAnnotations;

namespace SafeCode.Models
{
    public class Question
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; }
        public string Description { get; set; }
        public string CodeArea { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<UserQuestion> UserQuestions { get; set; }

        public int CategoriesId { get; set; }
        public Categories Categories { get; set; }

    }
}