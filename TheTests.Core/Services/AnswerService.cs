using TheTests.Core.Contracts;
using TheTests.Core.Models.Answer;

namespace TheTests.Core.Services
{
    public class AnswerService : IAnswerServices
    {
        public Task CreateAnswerAsync(AnswerEditModel model)
        {
            throw new NotImplementedException();
        }

        public Task<IList<AnswerEditModel>> GetAllAnswersByQuestionId(int questionId)
        {
            throw new NotImplementedException();
        }
    }
}
