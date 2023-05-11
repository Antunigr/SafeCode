using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace SafeCode.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Question> Iquestions { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}