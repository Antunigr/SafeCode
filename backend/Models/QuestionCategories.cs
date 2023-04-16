namespace SafeCode.Models
{
    public class QuestionCategories
    {
        public int CategoriesId { get; set; }
        public Categories Categories { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}