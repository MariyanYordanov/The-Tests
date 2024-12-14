using Microsoft.AspNetCore.Mvc.Rendering;
using TheTests.Core.Models.Question;

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
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Test description
        /// </summary>
        public string? Description { get; set; } = string.Empty;

        /// <summary>
        /// Test creator
        /// </summary>
        public string CreatorId { get; set; } = string.Empty;

        /// <summary>
        /// Test category
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Selected question type
        /// </summary>
        public int SelectedQuestionType { get; set; }

        /// <summary>
        /// The question types collection
        /// </summary>
        public IEnumerable<SelectListItem> QuestionTypes { get; set; } = new List<SelectListItem>();

        /// <summary>
        /// The categories collection
        /// </summary>
        public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();

        /// <summary>
        /// The questions collection
        /// </summary>
        public List<QuestionCreateModel> Questions { get; set; } = new();
    }
}
