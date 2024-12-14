using TheTests.Core.Contracts;
using TheTests.Core.Models.Answer;

namespace TheTests.Core.Services
{
    public class AnswerService : IAnswerServices
    {
        public Task CreateAnswerAsync(AnswerModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IList<AnswerModel>> GetAllAnswersByQuestionId(int questionId)
        {
            throw new NotImplementedException();
        }
    }
}
