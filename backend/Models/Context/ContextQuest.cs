using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SafeCode.Models
{
    public class ContextQuest : DbContext
    {
        public ContextQuest(DbContextOptions<ContextQuest> options) : base(options)
        {
        }

        public DbSet<Categories> CategoriesModel { get; set; }
        public DbSet<Question> QuestionModel { get; set; }


    }
}