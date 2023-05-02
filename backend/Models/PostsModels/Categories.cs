using System.ComponentModel.DataAnnotations;

namespace SafeCode.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Question> questions { get; set; }
    }
}