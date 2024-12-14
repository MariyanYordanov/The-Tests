using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheTests.Infrastructure.Data.Models;
using static TheTests.Infrastructure.Constants;

namespace TheTests.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>()
                .Property(u => u.FirstName)
                .HasMaxLength(MaxNameLength)
                .IsRequired();

            builder.Entity<AppUser>()
                .Property(u => u.LastName)
                .HasMaxLength(MaxNameLength)
                .IsRequired();

            builder.Entity<Test>()
                .HasOne(t => t.Creator)
                .WithMany()
                .HasForeignKey(t => t.CreatorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Test>()
                .HasOne(t => t.Category)
                .WithMany(c => c.Tests)
                .HasForeignKey(t => t.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Question>()
                .HasOne(q => q.Test)
                .WithMany(t => t.Questions)
                .HasForeignKey(q => q.TestId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Question>()
                .Property(q => q.Points)
                .IsRequired();

            builder.Entity<Question>()
                .Property(q => q.Description)
                .HasMaxLength(MaxDescriptionLength)
                .IsRequired();

            builder.Entity<Answer>()
                .HasOne(a => a.Question)
                .WithMany(q => q.Answers)
                .HasForeignKey(a => a.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Answer>()
                .Property(a => a.Text)
                .HasMaxLength(MaxDescriptionLength)
                .IsRequired();

            builder.Entity<Answer>()
                .Property(a => a.IsCorrect)
                .IsRequired();

            builder.Entity<Result>()
                .HasOne(r => r.Test)
                .WithMany(t => t.Results)
                .HasForeignKey(r => r.TestId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Result>()
                .HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Category>()
                .Property(c => c.Name)
                .HasMaxLength(MaxNameLength)
                .IsRequired();

            SeedData(builder);
        }

        private static void SeedData(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "General Knowledge" },
                new Category { Id = 2, Name = "Science" },
                new Category { Id = 3, Name = "History" }
            );

            var hasher = new PasswordHasher<AppUser>();
            builder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = "1",
                    FirstName = "John",
                    LastName = "Doe",
                    UserName = "john.doe",
                    NormalizedUserName = "JOHN.DOE",
                    Email = "john.doe@example.com",
                    NormalizedEmail = "JOHN.DOE@EXAMPLE.COM",
                    PasswordHash = hasher.HashPassword(null, "Password123!")
                },
                new AppUser
                {
                    Id = "2",
                    FirstName = "Jane",
                    LastName = "Smith",
                    UserName = "jane.smith",
                    NormalizedUserName = "JANE.SMITH",
                    Email = "jane.smith@example.com",
                    NormalizedEmail = "JANE.SMITH@EXAMPLE.COM",
                    PasswordHash = hasher.HashPassword(null, "Password123!")
                }
            );

            builder.Entity<Test>().HasData(
                new Test
                {
                    Id = 1,
                    Title = "Sample Test",
                    Description = "A test for demonstration purposes",
                    CreatorId = "1",
                    CategoryId = 1
                }
            );

            builder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    TestId = 1,
                    Description = "What is the capital of France?",
                    Points = 10
                }
            );

            builder.Entity<Answer>().HasData(
                new Answer
                {
                    Id = 1,
                    QuestionId = 1,
                    Text = "Paris",
                    IsCorrect = true
                },
                new Answer
                {
                    Id = 2,
                    QuestionId = 1,
                    Text = "London",
                    IsCorrect = false
                }
            );

            builder.Entity<Result>().HasData(
                new Result
                {
                    Id = 1,
                    TestId = 1,
                    UserId = "1",
                    Score = 100,
                    CompletedAt = DateTime.UtcNow
                }
            );
        }

        public DbSet<Test> Tests { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Question> Questions { get; set; } = null!;
        public DbSet<Answer> Answers { get; set; } = null!;
        public DbSet<Result> Results { get; set; } = null!;
    }
}
