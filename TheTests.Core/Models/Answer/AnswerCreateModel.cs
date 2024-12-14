namespace TheTests.Core.Models.Answer
{
    public class AnswerCreateModel
    {
        public string Text { get; set; } = string.Empty;

        public bool IsCorrect { get; set; }
    }
}