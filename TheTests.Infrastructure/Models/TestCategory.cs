using System.ComponentModel.DataAnnotations;
using static TheTests.Infrastructure.Constants;

namespace TheTests.Infrastructure.Models
{
    public class TestCategory
    {
        public int Id { get; set; }

        [Required]
        [StringLength(MaxNameLength)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Test> Tests { get; set; } = [];
    }
}
