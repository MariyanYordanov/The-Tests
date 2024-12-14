using System.ComponentModel.DataAnnotations;
using static TheTests.Core.ModelConstants;
using static TheTests.Core.ErrorMessages;
using TheTests.Core.Models.Question;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TheTests.Core.Models.Test
{
    public class TestCreateModel
    {
        [Required(ErrorMessage = RequierdField)]
        public int Id { get; set; }

        [Required(ErrorMessage = RequierdField)]
        public string Title { get; set; } = string.Empty;

        [StringLength(MaxDescriptionLength,
            MinimumLength = MinDescriptionLength,
            ErrorMessage = RequieredLength)]
        public string? Description { get; set; } = string.Empty;

        public string CreatorId { get; set; } = string.Empty;

        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; } = new List<SelectListItem>();

        public List<QuestionCreateModel> Questions { get; set; } = new List<QuestionCreateModel>();
    }
}
