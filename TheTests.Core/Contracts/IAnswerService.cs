using TheTests.Core.Models.Answer;

namespace TheTests.Core.Contracts
{
    public interface IAnswerServices
    {
        public Task<IList<AnswerModel>> GetAllAnswersByQuestionId(int questionId);

        public Task CreateAnswerAsync(AnswerModel model);
    }
}
