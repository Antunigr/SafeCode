using System.ComponentModel.DataAnnotations;

namespace SafeCode.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string User { get; set; } // trocar string for userModel
        public string Title { get; set; }
        public string Description { get; set; }
        public string CodeArea { get; set; }
        public int CategoryId { get; set; }
        public Categories CategoriesTag { get; set; }
    }
}