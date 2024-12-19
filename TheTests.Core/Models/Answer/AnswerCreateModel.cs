using System.ComponentModel.DataAnnotations;
using static TheTests.Core.ModelConstants;
using static TheTests.Core.ErrorMessages;

namespace TheTests.Core.Models.Answer
{
    public class AnswerCreateModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(MaxDescriptionLength, MinimumLength = MinDescriptionLength, ErrorMessage = RequieredLength)]
        public string Text { get; set; } = string.Empty;

        public bool IsCorrect { get; set; }
    }
}