using System.ComponentModel.DataAnnotations;
using TheTests.Infrastructure.Data.Models;
using static TheTests.Infrastructure.Constants;
using static TheTests.Core.ErrorMessages;
using TheTests.Core.Models.Answer;

namespace TheTests.Core.Models.Question
{
    /// <summary>
    /// This class represents the Question model.
    /// </summary>
    public class QuestionModel
    {
        /// <summary>
        /// The id of the question.
        /// </summary>
        [Required(ErrorMessage = RequierdField)]
        public int Id { get; set; }

        /// <summary>
        /// The title of the question.
        /// </summary>
        [Required(ErrorMessage = RequierdField)]
        [StringLength(MaxTitleLength,
            MinimumLength = MinTitleLength,
            ErrorMessage = RequieredLength)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The points of the question.
        /// </summary>
        [Required(ErrorMessage = RequierdField)]
        public int Points { get; set; }

        /// <summary>
        /// The description of the question.
        /// </summary>
        [StringLength(MaxDescriptionLength, 
            MinimumLength = MinDescriptionLength, 
            ErrorMessage = RequieredLength)]
        public string? Description { get; set; } = string.Empty;

        /// <summary>
        /// The type of the question.
        /// </summary>
        public ICollection<AnswerCreateModel> Answers { get; set; } = new List<AnswerCreateModel>();
    }
}
