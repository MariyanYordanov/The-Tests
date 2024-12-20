namespace TheTests.Core.Models.Question
{
    /// <summary>
    /// The model for the result of a question.
    /// </summary>
    public class QuestionResultModel
    {
        /// <summary>
        /// The text of the question.
        /// </summary>
        public string QuestionText { get; set; } = string.Empty;

        /// <summary>
        /// The user's answers for this question.
        /// </summary>
        public List<string> UserAnswers { get; set; } = new();

        /// <summary>
        /// The correct answers for this question.
        /// </summary>
        public List<string> CorrectAnswers { get; set; } = new();

        /// <summary>
        /// The points achieved by the user for this question.
        /// </summary>
        public int Points { get; set; }
    }
}

