using TheTests.Core.Models.Answer;
using TheTests.Infrastructure.Data.Models;

namespace TheTests.Core.Models.Question
{
    public class QuestionCreateModel
    {
        public string Text { get; set; } = string.Empty;

        public int Points { get; set; }

        public QuestionType QuestionType { get; set; }

        public List<AnswerCreateModel> Answers { get; set; } = new List<AnswerCreateModel>();
    }
}
