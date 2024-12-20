using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TheTests.Infrastructure.Constants;

namespace TheTests.Infrastructure.Data.Models
{
    /// <summary>
    /// The test entity.
    /// </summary>
    [Comment("The test entity.")]
    public class Test
    {
        /// <summary>
        /// The unique identifier for the test.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The title of the test.
        /// </summary>
        [Required]
        [StringLength(MaxTitleLength)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The description of the test.
        /// </summary>
        [StringLength(MaxDescriptionLength)]
        public string? Description { get; set; } = string.Empty;

        /// <summary>
        /// The time limit of the test.
        /// </summary>
        public bool IsActive{ get; set; } = false;

        /// <summary>
        /// The creator of the test.
        /// </summary>
        public string CreatorId { get; set; } = string.Empty;
        public AppUser Creator { get; set; } = null!;

        /// <summary>
        /// The category of the test.
        /// </summary>
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        /// <summary>
        /// The questions in the test.
        /// </summary>
        public ICollection<Question> Questions { get; set; } = new List<Question>();

        /// <summary>
        /// The results of the test.
        /// </summary>
        public ICollection<Result> Results { get; set; } = new List<Result>();

        /// <summary>
        /// The date and time the test was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time the test was last updated.
        /// </summary>
        public bool IsPublished { get; set; } = false;

        /// <summary>
        /// The duration of the test.
        /// </summary>
        public int PassPoints { get; set; }
    }
}



