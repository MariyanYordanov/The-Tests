using System.ComponentModel.DataAnnotations;
using static TheTests.Core.ModelConstants;
using static TheTests.Core.ErrorMessages;

namespace TheTests.Core.Models.Category
{
    public class CategoryModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(MaxNameLength,
            MinimumLength = MinNameLength, 
            ErrorMessage = RequieredLength)]
        public string Name { get; set; } = string.Empty;
    }
}
