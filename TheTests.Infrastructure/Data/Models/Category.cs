using System.ComponentModel.DataAnnotations;
using static TheTests.Infrastructure.Constants;

namespace TheTests.Infrastructure.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(MaxNameLength)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Test> Tests { get; set; } = new List<Test>();
    }
}
