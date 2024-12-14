using TheTests.Core.Models.Test;
using TheTests.Infrastructure.Data.Models;

namespace TheTests.Core.Contracts
{
    public interface ITestService
    {
        Task<IEnumerable<QuestionType>> GetQuestionTypesAsync();
        Task CreateTestAsync(TestCreateModel model);
    }
}
