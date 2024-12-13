using System.ComponentModel.DataAnnotations;
using static TheTests.Infrastructure.Constants;

namespace TheTests.Infrastructure.Data.Models;
public class Test
{
    public int Id { get; set; }

    [Required]
    [StringLength(MaxTitleLength)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [StringLength(MaxDescriptionLength)]
    public string Description { get; set; } = string.Empty;

    public string CreatorId { get; set; } = string.Empty;
    public AppUser Creator { get; set; } = null!;

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public ICollection<Question> Questions { get; set; } = new List<Question>();

    public ICollection<Result> Results { get; set; } = new List<Result>();
}

