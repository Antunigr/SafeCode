using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace SafeCode.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<Categories>()
            .HasMany(qc => qc.Question)
            .WithOne(cq => cq.Categories);

            modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserToken<string>>().HasNoKey();
        }

        public DbSet<Categories> CategoriesModel { get; set; }
        public DbSet<Question> QuestionModel { get; set; }
    }

    public class ApplicationUser : IdentityUser<Guid>
    {
        public string QuestionUser { get; set; }
        public Question QuestionId { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
            .Entity<Question>()
                .HasMany<ApplicationUser>()
                .WithOne()
                .HasForeignKey(au => au.QuestionId)
                .IsRequired();

        }
    }

}