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
            .Entity<QuestionCategories>()
            .HasKey(qc => new { qc.QuestionId, qc.CategoriesId });
        }


        public DbSet<Categories> CategoriesModel { get; set; }
        public DbSet<Question> QuestionModel { get; set; }
        public DbSet<QuestionCategories> QuestionCategoriesModel { get; set; }





    }
}