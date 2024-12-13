using System.ComponentModel.DataAnnotations;
using static TheTests.Infrastructure.Constants;

namespace TheTests.Infrastructure.Data.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        [StringLength(MaxTitleLength)]
        public string Title { get; set; } = string.Empty;

        [Required]  
        [StringLength(MaxPoints)]
        public int Points { get; set; }

        [Required]
        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public QuestionType QuestionType { get; set; }

        public ICollection<Answer> Answers { get; set; } = new List<Answer>();

        public int TestId { get; set; }
        public Test Test { get; set; } = null!;
    }
}

