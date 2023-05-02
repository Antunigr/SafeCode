using System.ComponentModel.DataAnnotations;

namespace SafeCode.Models
{
    public class Categories
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CategoryName { get; set; }
        public ICollection<QuestionCategory> QuestionCategories { get; set; }
    }
}