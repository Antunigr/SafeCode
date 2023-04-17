using System.ComponentModel.DataAnnotations;

namespace SafeCode.Models
{
    public class Question
    {
        [Key]
        public int id { get; set; }
        public int QuestionId { get; set; }
        public string User { get; set; } // trocar string for userModel
        public string Title { get; set; }
        public string Description { get; set; }
        public string CodeArea { get; set; }
        public int CategoriesId { get; set; }
        public Categories Categories { get; set; }


        public override string ToString()
        {
            return "QuestionId: " + this.QuestionId + " User: " + this.User + " Title: " + this.Title;
        }

    }
}