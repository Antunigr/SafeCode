using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace SafeCode.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Questions { get; set; }
        public List<Question> Iquestions { get; set; }
    }
}