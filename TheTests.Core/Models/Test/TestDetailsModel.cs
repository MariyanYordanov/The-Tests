using TheTests.Core.Models.Question;

namespace TheTests.Core.Models.Test
{
    public class TestDetailsModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Creator { get; set; } 
        public DateTime CreatedOn { get; set; }
        public bool IsPublished { get; set; }
        public bool IsActive { get; set; }
        public int QuestionsCount { get; set; }
        public int MaxPoints { get; set; }
        public int PassPoints { get; set; }
        public IEnumerable<QuestionModel> Questions { get; set; }
    }
}
