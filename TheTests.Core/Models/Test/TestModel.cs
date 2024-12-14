using System.ComponentModel.DataAnnotations;
using static TheTests.Core.ModelConstants;
using static TheTests.Core.ErrorMessages;

namespace TheTests.Core.Models.Test
{
    public class TestModel
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
    }
}
