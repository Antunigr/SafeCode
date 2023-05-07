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


            modelBuilder.Entity<IdentityUserLogin<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserRole<string>>().HasNoKey();
            modelBuilder.Entity<IdentityUserToken<string>>().HasNoKey();




        }
    }

}




//   modelBuilder.Entity<ApplicationUser>()
//             .HasMany(qc => qc.questions)
//             .WithOne(cq => cq.ApplicationUser)
//             .HasForeignKey(fk => fk.ApplicationUserId);

//             modelBuilder.Entity<Question>()
//             .HasMany(qc => qc.applicationUsers)
//             .WithOne(cq => cq.questions)
//             .HasForeignKey(fkq => fkq.QuestionsId)
//             .OnDelete(DeleteBehavior.Restrict);


//             modelBuilder.Entity<Categories>()
//             .HasMany(qc => qc.questions)
//             .WithOne(cq => cq.Categories);
