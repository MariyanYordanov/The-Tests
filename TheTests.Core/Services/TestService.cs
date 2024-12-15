using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TheTests.Core.Contracts;
using TheTests.Core.Models.Test;
using TheTests.Infrastructure.Data.Common;
using TheTests.Infrastructure.Data.Models;

namespace TheTests.Core.Services
{
    public class TestService : ITestService
    {
        private readonly IRepository _repository;
        private readonly UserManager<AppUser> _userManager;

        public TestService(IRepository repository, UserManager<AppUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
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
                Description = model.Description,
                CreatorId = model.CreatorId, 
                CategoryId = model.CategoryId,
                Questions = model.Questions.Select(q => new Question
                {
                    Description = q.Text,
                    Points = q.Points,
                    QuestionType = (QuestionType)model.SelectedQuestionType,
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


        public List<SelectListItem> GetQuestionTypes()
        {
            return Enum.GetValues(typeof(QuestionType))
                       .Cast<QuestionType>()
                       .Select(qt => new SelectListItem
                       {
                           Value = ((int)qt).ToString(),
                           Text = qt.ToString()
                       }).ToList();
        }


        public async Task<IEnumerable<TestModel>> GetAllTestsByUserIdAsync(string userId)
        {
            return await _repository.AllReadonly<Test>()
                .Where(t => t.CreatorId == userId)
                .Select(t => new TestModel
                {
                    Id = t.Id,
                    Title = t.Title,
                    Description = t.Description,
                    CategoryId = t.CategoryId
                }).ToListAsync();
        }
    }
}

