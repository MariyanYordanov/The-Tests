using TheTests.Core.Models.Question;

namespace TheTests.Core.Models.Test
{
    public class TestSolveModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty; 
        public List<QuestionSolveModel> Questions { get; set; } = new();
    }
}
