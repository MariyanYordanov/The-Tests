using System.ComponentModel.DataAnnotations;
using static TheTests.Core.ModelConstants;
using static TheTests.Core.ErrorMessages;

namespace TheTests.Core.Models.Test
{
    public class TestViewModel
    {
        /// <summary>
        /// The minimum length of the description.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The minimum length of the description.
        /// </summary>
        [Required(ErrorMessage = RequierdField)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The minimum length of the description.
        /// </summary>
        [StringLength(MaxDescriptionLength,
            MinimumLength = MinDescriptionLength,
            ErrorMessage = RequieredLength)]
        public string? Description { get; set; } = string.Empty;

        /// <summary>
        /// The minimum length of the description.
        /// </summary>
        public string CreatorId { get; set; } = string.Empty;

        /// <summary>
        /// The minimum length of the description.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// The minimum length of the description.
        /// </summary>
        public string CategoryName { get; set; } = string.Empty;

        /// <summary>
        /// The minimum length of the description.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// The minimum length of the description.
        /// </summary>
        public int SolvedCount { get; set; }

        /// <summary>
        /// The minimum length of the description.
        /// </summary>
        public bool IsPublished{ get; set; }
}
}

