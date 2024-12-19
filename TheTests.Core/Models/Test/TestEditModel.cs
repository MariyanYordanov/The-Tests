using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using TheTests.Core.Models.Question;
using static TheTests.Core.ErrorMessages;
using static TheTests.Core.ModelConstants;

namespace TheTests.Core.Models.Test
{
    /// <summary>
    /// The test edit model.
    /// </summary>
    public class TestEditModel
    {
        /// <summary>
        /// The minimum length of the description.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The title of the test.
        /// </summary>
        [Required(ErrorMessage = RequierdField)]
        [StringLength(MaxTestTitle, MinimumLength = MinTestTitle, ErrorMessage = RequieredLength)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// The description of the test.
        /// </summary>
        [StringLength(MaxDescriptionLength, MinimumLength = MinTitleLength, ErrorMessage = RequieredLength)]
        public string? Description { get; set; }

        /// <summary>
        /// The questions of the test.
        /// </summary>
        public List<QuestionEditModel> Questions { get; set; } = new List<QuestionEditModel>();
    }
}

