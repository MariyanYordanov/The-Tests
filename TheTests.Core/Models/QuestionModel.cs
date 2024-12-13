using System.ComponentModel.DataAnnotations;
using TheTests.Infrastructure.Data.Models.QuestionType;

namespace TheTests.Core.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public int Points { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public QuestionType QuestionType { get; set; }
    }
}
