using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static TheTests.Infrastructure.Constants;

namespace TheTests.Infrastructure.Data.Models
{
    /// <summary>
    /// The question entity.
    /// </summary>
    [Comment("The question entity.")]
    public class Question
    {
        /// <summary>
        /// The maximum length of the title.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The title of the question.
        /// </summary>
        [Required]
        [StringLength(MaxTitleLength)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The points of the question.
        /// </summary>
        [Required]  
        [StringLength(MaxPoints)]
        public int Points { get; set; }

        /// <summary>
        /// The description of the question.
        /// </summary>
        [Required]
        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The type of the question.
        /// </summary>
        [Required]
        public QuestionType QuestionType { get; set; }

        /// <summary>
        /// The answers of the question.
        /// </summary>
        public ICollection<Answer> Answers { get; set; } = new List<Answer>();

        /// <summary>
        /// The test of the question.
        /// </summary>
        public int TestId { get; set; }
        public Test Test { get; set; } = null!;
    }
}

