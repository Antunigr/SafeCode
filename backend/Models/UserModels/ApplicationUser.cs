using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace SafeCode.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public int Qid { get; set; }
        public string UserQId { get; set; } = Guid.NewGuid().ToString();
        public ICollection<Question> questions { get; set; }

    }
}