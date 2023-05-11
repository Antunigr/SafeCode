using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SafeCode.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Categories> CategoriesModel { get; set; }
        public DbSet<Question> QuestionModel { get; set; }
        public DbSet<Comment> CommentsModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Iquestions)
                .WithOne(q => q.ApplicationUser)
                .HasForeignKey(q => q.ApplicationUserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Question>()
                .HasOne(q => q.ApplicationUser)
                .WithMany(a => a.Iquestions)
                .HasForeignKey(q => q.ApplicationUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Categories>()
                .HasMany(qc => qc.questions)
                .WithOne(cq => cq.Categories);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Question)
                .WithMany(q => q.Comments)
                .HasForeignKey(c => c.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserToken<string>>().HasNoKey();
        }

        public class CommentConfiguration : IEntityTypeConfiguration<Comment>
        {
            public void Configure(EntityTypeBuilder<Comment> builder)
            {
                builder.HasKey(c => c.Id);
                builder.HasOne(c => c.Question)
                    .WithMany(q => q.Comments)
                    .HasForeignKey(c => c.QuestionId)
                    .OnDelete(DeleteBehavior.Cascade);
                builder.HasOne(c => c.ApplicationUser)
                    .WithMany(u => u.Comments)
                    .HasForeignKey(c => c.ApplicationUserId);
                builder.HasOne(c => c.ParentComment)
                    .WithMany(c => c.ChildrenComments)
                    .HasForeignKey(c => c.ParentCommentId)
                    .OnDelete(DeleteBehavior.Restrict);
            }
        }
    }

}
