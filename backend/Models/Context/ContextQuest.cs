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

        public DbSet<ApplicationUser> ApplicationUserModel { get; set; }
        public DbSet<Categories> CategoriesModel { get; set; }
        public DbSet<Question> QuestionModel { get; set; }
        public DbSet<QuestionCategory> QuestionCategories { get; set; }
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

            modelBuilder.Entity<QuestionCategory>()
           .HasKey(qc => new { qc.question_Id, qc.category_id });

            modelBuilder.Entity<QuestionCategory>()
           .HasOne(qc => qc.question)
           .WithMany(q => q.QuestionCategories)
           .HasForeignKey(qc => qc.question_Id);

            modelBuilder.Entity<QuestionCategory>()
            .HasOne(qc => qc.category)
            .WithMany(c => c.QuestionCategories)
            .HasForeignKey(qc => qc.category_id);

            // -----------------------------------------------------------

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

        }
    }

}