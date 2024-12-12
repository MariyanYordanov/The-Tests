using Microsoft.AspNetCore.Identity;
using TheTests.Infrastructure.Models;


namespace TheTests.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        public AppUser LoggedUser { get; set; }
        public AppUser GuestUser { get; set; }
        public AppUser Admin { get; set; }


        public TestCategory FirstCategory { get; set; }
        public TestCategory SecondCategory { get; set; }
        public TestCategory ThirdCategory { get; set; }



        public Test FirstTest { get; set; }
        public Test SecondTest { get; set; }
        public Test ThirdTest { get; set; }



        public Answer FirstAnswer { get; set; }
        public Answer SecondAnswer { get; set; }
        public Answer ThirdAnswer { get; set; }



        public Question FirstQuestion { get; set; }
        public Question SecondQuestion { get; set; }
        public Question ThirdQuestion { get; set; }


        public SeedData()
        {
            SeedUsers();
            SeedTests();
            SeedQuestion();
            SeedTestCategories();
            SeedAnswers();
            SeedTestResults();
        }

        private void SeedUsers()
        {
            LoggedUser = new AppUser("LoggedUser")
            {
                Id = "1",
                FirstName = "Logged",
                LastName = "User",
                Email = "logged@mail.com",
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = true,
                LockoutEnabled = false,
                UserName = "LoggedUser",
                NormalizedUserName = "LOGGEDUSER",
                NormalizedEmail = "LOGGED@MAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PasswordHash = new PasswordHasher<AppUser>().HashPassword(null, "LoggedUser123!"),
            };

            GuestUser = new AppUser("GuestUser")
            {
                Id = "2",
                FirstName = "Guest",
                LastName = "User",
                Email = "guest@mail.com",
                EmailConfirmed = true,
                PhoneNumber = "987654321",
                PhoneNumberConfirmed = true,
                LockoutEnabled = false,
                UserName = "GuestUser",
                NormalizedUserName = "GUESTUSER",
                NormalizedEmail = "GUEST@MAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PasswordHash = new PasswordHasher<AppUser>().HashPassword(null, "GuestUser123!"),
            };

            Admin = new AppUser("Admin")
            {
                Id = "3",
                FirstName = "Admin",
                LastName = "User",
                Email = "admin@mail.com",
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = true,
                LockoutEnabled = false,
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                NormalizedEmail = "GUEST@MAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PasswordHash = new PasswordHasher<AppUser>().HashPassword(null, "Admin123!"),
            };
        }
        private void SeedTests()
        {
            FirstTest = new Test
            {
                Id = 1,
                Title = "First Test",
                Description = "First Test Description",
                CategoryId = FirstCategory.Id,
                CreatorId = LoggedUser.Id,

            };

            SecondTest = new Test
            {
                Id = 2,
                Title = "Second Test",
                Description = "Second Test Description",
                CategoryId = SecondCategory.Id,
                CreatorId = LoggedUser.Id
            };

            ThirdTest = new Test
            {
                Id = 3,
                Title = "Third Test",
                Description = "Third Test Description",
                CategoryId = ThirdCategory.Id,
                CreatorId = LoggedUser.Id
            };
        }
        private void SeedQuestion()
        {
            FirstQuestion = new Question
            {
                Id = 1,
                Description = "First Question Description",
                Points = 10,
                TestId = FirstTest.Id
            };

            SecondQuestion = new Question
            {

                Id = 2,
                Description = "Second Question Description",
                Points = 20,
                TestId = SecondTest.Id
            };

            ThirdQuestion = new Question
            {

                Id = 3,
                Description = "Third Question Description",
                Points = 30,
                TestId = ThirdTest.Id
            };
        }

        private void SeedAnswers()
        {
            FirstAnswer = new Answer
            {

                Id = 1,
                Text = "First Answer",
                IsCorrect = true,
                QuestionId = FirstQuestion.Id
            };

            SecondAnswer = new Answer
            {

                Id = 2,
                Text = "Second Answer",
                IsCorrect = false,
                QuestionId = SecondQuestion.Id
            };

            ThirdAnswer = new Answer
            {

                Id = 3,
                Text = "Third Answer",
                IsCorrect = true,
                QuestionId = ThirdQuestion.Id
            };
        }


        private void SeedTestCategories()
        {
            FirstCategory = new TestCategory
            {
                Id = 1,
                Name = "First Category"
            };

            SecondCategory = new TestCategory
            {

                Id = 2,
                Name = "Second Category"
            };

            ThirdCategory = new TestCategory
            {

                Id = 3,
                Name = "Third Category"
            };
        }



        private void SeedTestResults()
        {
            var firstTestResult = new TestResult
            {
                TestId = FirstTest.Id,
                UserId = LoggedUser.Id,
                Score = 100
            };

            var secondTestResult = new TestResult
            {
                TestId = SecondTest.Id,
                UserId = LoggedUser.Id,
                Score = 50
            };

            var thirdTestResult = new TestResult
            {
                TestId = ThirdTest.Id,
                UserId = LoggedUser.Id,
                Score = 75
            };

        }
    }
}
