using TheTests.Core.Models.Question;

namespace TheTests.Core.Models.Result
{
    /// <summary>
    /// The model for the result of a test.
    /// </summary>
    public class MyResultsModel
    {
        /// <summary>
        /// The unique identifier for the test.
        /// </summary>
        public string TestTitle { get; set; } = string.Empty;

        /// <summary>
        /// The date and time when the test was started.
        /// </summary>
        public DateTime CompletedAt { get; set; }

        /// <summary>
        /// The total points that can be achieved.
        /// </summary>
        public int TotalPoints { get; set; }

        /// <summary>
        /// The points achieved by the user.
        /// </summary>
        public int UserPoints { get; set; }

        /// <summary>
        /// The questions in the test.
        /// </summary>
        public List<QuestionResultModel> Questions { get; set; } = new();
    }

}

