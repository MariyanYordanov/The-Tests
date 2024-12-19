using System.ComponentModel.DataAnnotations;
using TheTests.Core.Models.Answer;
using TheTests.Infrastructure.Data.Models;
using static TheTests.Core.ErrorMessages;

namespace TheTests.Core.Models.Question
{
    public class QuestionCreateModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequierdField)]
        public string Text { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Points must be greater than 0.")]
        public int Points { get; set; }

        public string? Description { get; set; } = string.Empty;

        [Required(ErrorMessage = RequierdField)]
        public QuestionType QuestionType { get; set; }

        [MinLength(2, ErrorMessage = "At least two answers are required.")]
        [CustomValidation(typeof(QuestionCreateModel), nameof(ValidateAnswers))]
        public List<AnswerCreateModel> Answers { get; set; } = new List<AnswerCreateModel>();

        public static ValidationResult ValidateAnswers(List<AnswerCreateModel> answers, ValidationContext context)
        {
            if (answers.Any(a => a.IsCorrect == true))
            {
                return ValidationResult.Success!;
            }
            return new ValidationResult("At least one answer must be marked as correct.");
        }

    }

}
