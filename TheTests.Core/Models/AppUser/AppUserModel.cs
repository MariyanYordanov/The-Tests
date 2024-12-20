using System.ComponentModel.DataAnnotations;
using static TheTests.Core.ModelConstants;
using static TheTests.Core.ErrorMessages;

namespace TheTests.Core.Models.AppUser
{
    public class AppUserModel 
    {
        [Required]
        public string Id { get; set; } = null!;

        [StringLength(MaxNameLength,
            ErrorMessage = RequieredLength,
            MinimumLength = MinNameLength)]
        public string FirstName { get; set; } = null!;

        [StringLength(MaxNameLength,
            ErrorMessage = RequieredLength,
            MinimumLength = MinNameLength)]
        public string? LastName { get; set; } = null!;

        public string FullName => $"{FirstName} {LastName}";

        public string DisplayName => string.IsNullOrWhiteSpace(FullName) ? Id : FullName;
    }
}
