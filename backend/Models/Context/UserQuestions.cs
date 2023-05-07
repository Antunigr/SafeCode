
namespace SafeCode.Models
{
    public class UserQuestion
    {
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public string QuestionId { get; set; }
        public Question Question { get; set; }
    }
}