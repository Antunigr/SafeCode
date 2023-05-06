using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace SafeCode.Models
{
    public class ApplicationUser : IdentityUser
    {
        // public int Qid { get; set; }
        public string UserQId { get; set; }
        public string? QuestionsId { get; set; }
        public Question? Questions { get; set; }
        public ICollection<Question> questions { get; set; }

    }
}