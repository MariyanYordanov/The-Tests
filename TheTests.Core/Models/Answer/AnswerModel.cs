using System.ComponentModel.DataAnnotations;
using static TheTests.Core.ModelConstants;
using static TheTests.Core.ErrorMessages;

namespace TheTests.Core.Models.Answer
{
    /// <summary>
    /// Represents a model for an answer.
    /// </summary>
    public class AnswerModel
    {
        /// <summary>
        /// Gets or sets the ID of the answer.
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the description of the answer.
        /// </summary>
        [Required(ErrorMessage = RequierdField)]
        [StringLength(MaxDescriptionLength,
            ErrorMessage = RequieredLength,
            MinimumLength = MinDescriptionLength)]
        public string Text { get; set; } = null!;

        /// <summary>
        /// Gets or sets a value indicating whether the answer is correct.
        /// </summary>
        [Required]
        public bool IsCorrect { get; set; }
    }
}