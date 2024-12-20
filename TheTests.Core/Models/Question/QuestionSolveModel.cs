using TheTests.Core.Models.Answer;

namespace TheTests.Core.Models.Question
{
    public class QuestionSolveModel
    {
        public int Id { get; set; } 
        public string Text { get; set; } = string.Empty; 
        public List<AnswerSolveModel> Answers { get; set; } = new();
    }
}
