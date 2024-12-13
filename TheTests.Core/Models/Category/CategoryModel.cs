using System.ComponentModel.DataAnnotations;
using static TheTests.Core.ModelConstants;

namespace TheTests.Core.Models.Category
{
    public class CategoryModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(MaxNameLength)]
        public string Name { get; set; } = string.Empty;
    }
}
