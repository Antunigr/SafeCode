using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace SafeCode.Models
{
    public class ContextQuest : DbContext
    {
        public ContextQuest(DbContextOptions<ContextQuest> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<Categories>()
            .HasMany(qc => qc.Question)
            .WithOne(cq => cq.Categories);
        }



        public DbSet<Categories> CategoriesModel { get; set; }
        public DbSet<Question> QuestionModel { get; set; }





    }
}