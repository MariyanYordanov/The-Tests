using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using static TheTests.Core.ErrorMessages;
using static TheTests.Core.ModelConstants;

namespace TheTests.Core.Models.Test
{
    /// <summary>
    /// Test create model
    /// </summary>
    public class TestCreateModel
    {
        /// <summary>
        /// Test title
        /// </summary>
        [Required(ErrorMessage = RequierdField)]
        [StringLength(MaxTitleLength,
            MinimumLength = MinTitleLength,
            ErrorMessage = RequieredLength)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Test description
        /// </summary>
        [StringLength(MaxDescriptionLength, 
            MinimumLength = MinDescriptionLength, 
            ErrorMessage = RequieredLength)]
        public string? Description { get; set; } = string.Empty;

        /// <summary>
        /// Test creator
        /// </summary>
        public int CategoryId { get; set; }


        /// <summary>
        /// The creator of the test
        /// </summary>
        public string? CreatorId { get; set; } = string.Empty;

        /// <summary>
        /// The categories collection
        /// </summary>
        public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
    }
}
