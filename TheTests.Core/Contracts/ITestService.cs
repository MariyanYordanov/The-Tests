using TheTests.Core.Models.Test;
using TheTests.Infrastructure.Data.Models;

namespace TheTests.Core.Contracts
{
    public interface ITestService
    {
        Task<IEnumerable<TestViewModel>> GetAllTestsByUserIdAsync(string userId);
        Task<int> CreateTestAsync(TestCreateModel model);

        Task ActivateTestAsync(int testId, string userId);

        Task<TestStatisticsViewModel> GetTestStatisticsAsync(int testId, string userId);

        Task<TestEditModel> EditTestAsync(int testId, string userId);

        Task UpdateTestAsync(TestEditModel model);

        Task<TestEditModel> GetTestForEditAsync(int testId, string userId);

        Task<Result> EvaluateTestAsync(TestSubmissionModel model, string userId);

        Task<TestSolveModel> GetTestForSolvingAsync(int testId, string userId);

        Task PublishTestAsync(int testId);

        Task<IEnumerable<TestViewModel>> GetPublishedTestsAsync();
    }
}
