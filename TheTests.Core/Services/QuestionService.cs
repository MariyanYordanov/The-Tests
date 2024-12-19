using TheTests.Core.Contracts;
using TheTests.Core.Models.Question;

namespace TheTests.Core.Services
{
    public class QuestionService : IQuestionService
    {
        public Task<QuestionCreateModel> CreateQuestionAsync(QuestionCreateModel model)
        {
            var question = new QuestionCreateModel
            {
                Text = model.Text,
                Points = model.Points,
                Description = model.Description,
                QuestionType = model.QuestionType,
                Answers = model.Answers
            };

            return Task.FromResult(question);
        }
    }
}
