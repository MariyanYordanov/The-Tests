using TheTests.Core.Models.Question;

namespace TheTests.Core.Contracts
{
    public interface IQuestionService
    {
        Task<QuestionCreateModel> CreateQuestionAsync(QuestionCreateModel model);
    }
}
