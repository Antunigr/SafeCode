namespace SafeCode.Models
{
    public class QuestionCategory
    {
        public string question_Id { get; set; }
        public Question question { get; set; }
        public string category_id { get; set; }
        public Categories category { get; set; }
    }

}