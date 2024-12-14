using System.ComponentModel.DataAnnotations;
using static TheTests.Infrastructure.Constants;

namespace TheTests.Infrastructure.Data.Models
{
    /// <summary>
    /// The category entity.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// The unique identifier for the category.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the category.
        /// </summary>
        [Required]
        [StringLength(MaxNameLength)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The tests in the category.
        /// </summary>
        public ICollection<Test> Tests { get; set; } = new List<Test>();
    }
}
