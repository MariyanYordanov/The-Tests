using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheTests.Core.Contracts;
using TheTests.Core.Models.Answer;
using TheTests.Core.Models.Question;
using TheTests.Core.Models.Test;
using TheTests.Infrastructure.Data.Common;
using TheTests.Infrastructure.Data.Models;

namespace TheTests.Core.Services
{
    public class TestService : ITestService
    {
        private readonly IRepository _repository;

        public TestService(IRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// The method returns all tests.
        /// </summary>
        /// <param name="testId"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task DeleteTestAsync(int testId)
        {
            var test = await _repository.All<Test>().FirstOrDefaultAsync(t => t.Id == testId);
            if (test == null)
                throw new ArgumentException("Test not found.");

            _repository.Delete(test);
            await _repository.SaveChangesAsync();
        }

        /// <summary>
        /// The method returns all tests.
        /// </summary>
        /// <param name="testId"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<TestDetailsModel> GetTestDetailsAsync(int testId)
        {
            var test = await _repository.AllReadonly<Test>()
                .Include(tc => tc.Category)
                .Include(t => t.Questions)
                .ThenInclude(q => q.Answers)
                .FirstOrDefaultAsync(t => t.Id == testId);

            if (test == null)
                throw new ArgumentException($"Test with ID {testId} not found.");

            if (test.Category == null)
                throw new ArgumentException($"Category not found for the test with ID {testId}.");

            return new TestDetailsModel
            {
                Id = test.Id,
                Title = test.Title,
                Description = test.Description,
                Category = test.Category?.Name ?? "Uncategorized",
                Creator = test.Creator?.UserName ?? "Unknown",
                CreatedOn = test.CreatedAt,
                IsActive = test.IsActive,
                MaxPoints = test.Questions.Sum(q => q.Points),
                PassPoints = test.PassPoints > 0 ? test.PassPoints : 0,
                QuestionsCount = test.Questions.Count,
                Questions = test.Questions.Select(q => new QuestionModel
                {
                    Id = q.Id,
                    Description = q.Description,
                    Points = q.Points,
                    Answers = q.Answers.Select(a => new AnswerCreateModel
                    {
                        Id = a.Id,
                        Text = a.Text,
                        IsCorrect = a.IsCorrect
                    }).ToList()
                }).ToList()
            };
        }


        /// <summary>
        /// `The method evaluates the test.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<Result> EvaluateTestAsync(TestSubmissionModel model, string userId)
        {
            var test = await _repository.AllReadonly<Test>()
                .Include(t => t.Questions)
                .ThenInclude(q => q.Answers)
                .FirstOrDefaultAsync(t => t.Id == model.Id && t.IsActive);

            if (test == null)
            {
                throw new ArgumentException("Test not found or inactive.");
            }

            int totalPoints = 0;
            foreach (var question in test.Questions)
            {
                var correctAnswers = question.Answers.Where(a => a.IsCorrect).Select(a => a.Id).ToList();
                var userAnswers = model.Answers[question.Id];
                if (correctAnswers.SequenceEqual(userAnswers))
                {
                    totalPoints += question.Points;
                }
            }

            var result = new Result
            {
                UserId = userId,
                TestId = model.Id,
                Score = totalPoints,
                CompletedAt = DateTime.UtcNow
            };

            await _repository.AddAsync(result);
            await _repository.SaveChangesAsync();

            return result;
        }


        /// <summary>
        /// The method returns a test for solving.
        /// </summary>
        /// <param name="testId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<TestSolveModel> GetTestForSolvingAsync(int testId, string userId)
        {
            var test = await _repository.AllReadonly<Test>()
                .Include(t => t.Questions)
                .ThenInclude(q => q.Answers)
                .FirstOrDefaultAsync(t => t.Id == testId && t.IsActive);

            if (test == null)
            {
                return null;
            }

            return new TestSolveModel
            {
                Id = test.Id,
                Title = test.Title,
                Questions = test.Questions.Select(q => new QuestionSolveModel
                {
                    Id = q.Id,
                    Text = q.Description,
                    Answers = q.Answers.Select(a => new AnswerSolveModel
                    {
                        Id = a.Id,
                        Text = a.Text
                    }).ToList()
                }).ToList()
            };

        }


        /// <summary>
        /// The method creates a question.
        /// </summary>
        public async Task ActivateTestAsync(int testId, string userId)
        {
            var test = await _repository.All<Test>()
                .FirstOrDefaultAsync(t => t.Id == testId && t.CreatorId == userId);

            if (test == null)
                throw new ArgumentException("Test not found or access denied.");

            test.IsActive = true;

            await _repository.SaveChangesAsync();
        }


        /// <summary>
        /// The method creates a question.
        /// </summary>
        public async Task<int> CreateTestAsync(TestCreateModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model), "Model cannot be null.");

            if (string.IsNullOrEmpty(model.CreatorId))
                throw new ArgumentException("CreatorId is required.");

            var categoryExists = await _repository
                .AllReadonly<Category>()
                .AnyAsync(c => c.Id == model.CategoryId);

            if (!categoryExists)
                throw new ArgumentException("Selected category does not exist.");

            var test = new Test
            {
                Title = model.Title,
                Description = model.Description,
                CategoryId = model.CategoryId,
                CreatorId = model.CreatorId,
                IsActive = false,
                CreatedAt = DateTime.UtcNow,
                PassPoints = model.PassPoints,
            };

            await _repository.AddAsync(test);
            await _repository.SaveChangesAsync();

            return test.Id;
        }

        /// <summary>
        /// The method creates a question.
        /// </summary>
        [HttpPost]
        public async Task<TestEditModel> EditTestAsync(int testId, string userId)
        {
            var test = await _repository.AllReadonly<Test>()
                .Include(t => t.Questions)
                .ThenInclude(q => q.Answers)
                .FirstOrDefaultAsync(t => t.Id == testId && t.CreatorId == userId);

            if (test == null)
                throw new ArgumentException("Test not found or access denied.");

            var model = new TestEditModel
            {
                Id = test.Id,
                Title = test.Title,
                Description = test.Description,
                Questions = test.Questions.Select(q => new QuestionEditModel
                {
                    Id = q.Id,
                    Text = q.Description,
                    Points = q.Points,
                    Answers = q.Answers.Select(a => new AnswerEditModel
                    {
                        Id = a.Id,
                        Text = a.Text,
                        IsCorrect = a.IsCorrect
                    }).ToList()
                }).ToList()
            };

            await _repository.AddAsync(test);
            await _repository.SaveChangesAsync();

            return model;
        }

        /// <summary>
        /// The method updates the test.
        /// </summаry>
        public async Task UpdateTestAsync(TestEditModel model)
        {
            var test = await _repository.All<Test>()
                .Include(t => t.Questions)
                .ThenInclude(q => q.Answers)
                .FirstOrDefaultAsync(t => t.Id == model.Id);

            if (test == null)
            {
                throw new Exception($"Test with ID {model.Id} not found.");
            }

            test.Title = model.Title;
            test.Description = model.Description;

            foreach (var question in model.Questions)
            {
                var existingQuestion = test.Questions.FirstOrDefault(q => q.Id == question.Id);
                if (existingQuestion != null)
                {
                    existingQuestion.Description = question.Text;
                    existingQuestion.Points = question.Points;
                }
            }

            await _repository.SaveChangesAsync();
            Console.WriteLine($"Test updated successfully!");
        }

        /// <summary>
        /// The method returns all tests created by the user.
        /// </summary>
        public async Task<IEnumerable<TestViewModel>> GetAllTestsByUserIdAsync(string userId)
        {
            return await _repository.AllReadonly<Test>()
                .Where(t => t.CreatorId == userId)
                .Select(t => new TestViewModel
                {
                    Id = t.Id,
                    Title = t.Title,
                    Description = t.Description,
                    CategoryId = t.CategoryId,
                    CategoryName = t.Category.Name,
                    IsActive = t.IsActive,
                    SolvedCount = t.Results.Count
                }).ToListAsync();
        }

        public async Task<TestEditModel>GetTestForEditAsync(int testId, string userId)
        {
            var test = await _repository.AllReadonly<Test>()
                .Include(t => t.Questions)
                .ThenInclude(q => q.Answers)
                .FirstOrDefaultAsync(t => t.Id == testId && t.CreatorId == userId);

            if (test == null)
                throw new ArgumentException("Test not found or access denied.");

            return new TestEditModel
            {
                Id = test.Id,
                Title = test.Title,
                Description = test.Description,
                Questions = test.Questions.Select(q => new QuestionEditModel
                {
                    Id = q.Id,
                    Text = q.Description,
                    Points = q.Points,
                    Answers = q.Answers.Select(a => new AnswerEditModel
                    {
                        Id = a.Id,
                        Text = a.Text,
                        IsCorrect = a.IsCorrect
                    }).ToList()
                }).ToList()
            };
        }

        /// <summary>
        /// The method returns all tests.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TestViewModel>> GetPublishedTestsAsync()
        {
            var tests = await _repository.AllReadonly<Test>()
                .Where(t => t.IsActive)
                .Select(t => new TestViewModel
                {
                    Id = t.Id,
                    Title = t.Title,
                    Description = t.Description,
                    CreatorId = t.CreatorId,
                    CategoryId = t.CategoryId,
                    CategoryName = t.Category.Name,
                    IsActive = t.IsActive,
                    SolvedCount = t.Results.Count
                }).ToListAsync();

            return tests;
        }


        public Task DeactivateTestAsync(int testId)
        {
            var test = _repository.All<Test>().FirstOrDefault(t => t.Id == testId);

            if (test == null)
                throw new ArgumentException("Test not found.");

            test.IsActive = false;

            return _repository.SaveChangesAsync();
        }

    }
}
