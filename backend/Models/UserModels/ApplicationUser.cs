using Microsoft.AspNetCore.Identity;

namespace SafeCode.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string UserQId { get; set; }
        public ICollection<UserQuestion> UserQuestions { get; set; }

    }
}