namespace SafeCode.Models
{
    public class UserQuestion
    {
        public string user_id { get; set; }
        public ApplicationUser applicationUser { get; set; }
        public string question_id { get; set; }
        public Question question { get; set; }
    }
}