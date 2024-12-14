using System.ComponentModel.DataAnnotations;
using TheTests.Infrastructure.Data.Models;
using static TheTests.Infrastructure.Constants;
using static TheTests.Core.ErrorMessages;

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
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The points of the question.
        /// </summary>
        [Required(ErrorMessage = RequierdField)]
        public int Points { get; set; }

        /// <summary>
        /// The description of the question.
        /// </summary>
        [Required]
        [StringLength(MaxDescriptionLength, 
            MinimumLength = MinDescriptionLength, 
            ErrorMessage = RequieredLength)]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The test id of the question.
        /// </summary>
        [Required(ErrorMessage = RequierdField)]
        public QuestionType QuestionType { get; set; }
    }
}
