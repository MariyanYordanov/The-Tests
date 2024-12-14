using TheTests.Core.Contracts;
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

        public async Task<IEnumerable<QuestionType>> GetQuestionTypesAsync()
        {
            return await Task.FromResult(Enum.GetValues(typeof(QuestionType)).Cast<QuestionType>());
        }

        public async Task CreateTestAsync(TestCreateModel model)
        {
            var test = new Test
            {
                Title = model.Title,
                Questions = model.Questions.Select(q => new Question
                {
                    Description = q.Text,
                    Points = q.Points,
                    QuestionType = q.QuestionType,
                    Answers = q.Answers.Select(a => new Answer
                    {
                        Text = a.Text,
                        IsCorrect = a.IsCorrect
                    }).ToList()
                }).ToList()
            };

            await _repository.AddAsync(test);
            await _repository.SaveChangesAsync();
        }
    }
}

