using System.ComponentModel.DataAnnotations;

namespace SafeCode.Models
{
    public class Categories
    {
        [Key]
        public int CategoriesId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Question> Question { get; set; }

    }
}