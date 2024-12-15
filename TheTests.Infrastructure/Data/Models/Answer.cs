using Microsoft.EntityFrameworkCore;

namespace TheTests.Infrastructure.Data.Models
{
    /// <summary>
    /// The answer entity.
    /// </summary>
    [Comment("The answer entity.")]
    public class Answer
    {
        /// <summary>
        /// The unique identifier for the answer.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The text of the answer.
        /// </summary>
        public string? Text { get; set; } = string.Empty;

        /// <summary>
        /// The value of the answer.
        /// </summary>
        public bool IsCorrect { get; set; }

        /// <summary>
        /// The question of the answer.
        /// </summary>
        public int QuestionId { get; set; }
        public Question Question { get; set; } = null!;
    }
}
