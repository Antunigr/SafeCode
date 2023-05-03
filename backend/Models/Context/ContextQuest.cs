using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace SafeCode.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Categories> CategoriesModel { get; set; }
        public DbSet<Question> QuestionModel { get; set; }
        public DbSet<UserQuestion> UserQuestions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<Question>()
                .HasKey(q => q.Id);

            modelBuilder.Entity<Categories>()
            .HasKey(c => c.Id);

            modelBuilder.Entity<UserQuestion>()
                .HasKey(uq => new { uq.user_id, uq.question_id });

            modelBuilder.Entity<UserQuestion>()
                .HasOne(uq => uq.applicationUser)
                .WithMany(u => u.UserQuestions)
                .HasForeignKey(uq => uq.user_id);

            modelBuilder.Entity<UserQuestion>()
                .HasOne(uq => uq.question)
                .WithMany(q => q.UserQuestions)
                .HasForeignKey(uq => uq.question_id);

            modelBuilder.Entity<ApplicationUser>().HasKey(u => u.Id);

            modelBuilder.Entity<Categories>()
            .HasMany(qc => qc.questions)
            .WithOne(cq => cq.Categories);

        }
    }

}