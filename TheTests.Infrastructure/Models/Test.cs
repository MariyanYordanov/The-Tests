using System.ComponentModel.DataAnnotations;
using static TheTests.Infrastructure.Constants;

namespace TheTests.Infrastructure.Models;
public class Test
{
    public int Id { get; set; }

    [Required]
    [StringLength(MaxTitleLength)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [StringLength(MaxDescriptionLength)]
    public string Description { get; set; } = string.Empty;

    public string CreatorId { get; set; }
    public AppUser Creator { get; set; } = null!;

    public int CategoryId { get; set; }
    public TestCategory Category { get; set; } = null!;

    public ICollection<Question> Questions { get; set; } = [];

    public ICollection<TestResult> Results { get; set; } = [];
}

