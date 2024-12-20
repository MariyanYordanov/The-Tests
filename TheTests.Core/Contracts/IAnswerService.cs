using TheTests.Core.Models.Answer;

namespace TheTests.Core.Contracts
{
    public interface IAnswerServices
    {
        public Task<IList<AnswerEditModel>> GetAllAnswersByQuestionId(int questionId);

    }
}
