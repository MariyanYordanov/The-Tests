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
        public async Task<TestStatisticsViewModel> GetTestStatisticsAsync(int testId, string userId)
        {
            var test = await _repository.AllReadonly<Test>()
                .Include(t => t.Results)
                .ThenInclude(r => r.Score)
                .FirstOrDefaultAsync(t => t.Id == testId && t.CreatorId == userId);

            if (test == null)
                throw new ArgumentException("Test not found or access denied.");

            return new TestStatisticsViewModel
            {
                TestTitle = test.Title,
                SolvedCount = test.Results.Count,
                AverageScore = test.Results.Any() ? test.Results.Average(r => r.Score) : 0
            };
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
                IsActive = false
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
            Console.WriteLine($"Updating Test. ID: {model.Id}, Title: {model.Title}");

            var test = await _repository.All<Test>()
                .Include(t => t.Questions)
                .ThenInclude(q => q.Answers)
                .FirstOrDefaultAsync(t => t.Id == model.Id);

            if (test == null)
            {
                throw new Exception($"Test with ID {model.Id} not found.");
            }

            Console.WriteLine($"Loaded Test: {test.Title}, Questions: {test.Questions.Count}");

            test.Title = model.Title;
            test.Description = model.Description;

            foreach (var question in model.Questions)
            {
                Console.WriteLine($"Processing Question ID: {question.Id}, Text: {question.Text}");

                var existingQuestion = test.Questions.FirstOrDefault(q => q.Id == question.Id);
                if (existingQuestion != null)
                {
                    existingQuestion.Description = question.Text;
                    existingQuestion.Points = question.Points;

                    foreach (var answer in question.Answers)
                    {
                        Console.WriteLine($"Processing Answer ID: {answer.Id}, Text: {answer.Text}, IsCorrect: {answer.IsCorrect}");
                    }
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
                    CategoryId = t.CategoryId
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

        public Task PublishTestAsync(int testId)
        {
            var test = _repository.All<Test>().FirstOrDefault(t => t.Id == testId);
            if (test == null)
                throw new ArgumentException("Test not found.");

            test.IsActive = true;
            return _repository.SaveChangesAsync();
        }
    }
}
