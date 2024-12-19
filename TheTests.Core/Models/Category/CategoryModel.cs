using System.ComponentModel.DataAnnotations;
using static TheTests.Core.ModelConstants;
using static TheTests.Core.ErrorMessages;

namespace TheTests.Core.Models.Category
{
    public class CategoryModel
    {
        /// <summary>
        /// The minimum length of the name of the category
        /// </summary>
        public int Id { get; set; }
        [Required]
        [StringLength(MaxNameLength,
            MinimumLength = MinNameLength, 
            ErrorMessage = RequieredLength)]
        public string Name { get; set; } = string.Empty;
    }
}
