using TheTests.Core.Models.Question;

namespace TheTests.Core.Models.Test
{
    public class TestSubmissionModel
    {
        public int Id { get; set; } 
        public Dictionary<int, List<int>> Answers { get; set; } = new();
    }
}
