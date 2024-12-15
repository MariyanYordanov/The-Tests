using Microsoft.AspNetCore.Mvc.Rendering;
using TheTests.Core.Models.Test;
using TheTests.Infrastructure.Data.Models;

namespace TheTests.Core.Contracts
{
    public interface ITestService
    {
        Task<IEnumerable<TestModel>> GetAllTestsByUserIdAsync(string userId);
        Task<IEnumerable<QuestionType>> GetQuestionTypesAsync();
        Task CreateTestAsync(TestCreateModel model);
        public List<SelectListItem> GetQuestionTypes();
    }
}
