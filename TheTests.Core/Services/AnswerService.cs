using TheTests.Core.Contracts;
using TheTests.Core.Models.Answer;
using TheTests.Infrastructure.Data.Common;

namespace TheTests.Core.Services
{
    public class AnswerService : IAnswerServices
    {
        private readonly IRepository _repository;   
       
        public async Task<IList<AnswerEditModel>> GetAllAnswersByQuestionId(int questionId)
        {
            var answers = _repository.All<AnswerEditModel>().Where(x => x.QuestionId == questionId).ToList();

            return answers;
        }
    }
}
