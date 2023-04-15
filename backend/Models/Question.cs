
namespace SafeCode.Models.Question
{
    public class Question
    {
        public int Id { get; }
        public string User { get; set; } // trocar string for userModel
        public string Title { get; set; }
        public string Description { get; set; }
        public string CodeArea { get; set; }
        public Categories.Categories CategoriesTag { get; set; }
    }
}