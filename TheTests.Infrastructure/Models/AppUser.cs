using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static TheTests.Infrastructure.Constants;

namespace TheTests.Infrastructure.Models
{
    public sealed class AppUser(string userName) : IdentityUser(userName)
    {
        [Required]
        [StringLength(MaxNameLength)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(MaxNameLength)]
        public string LastName { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}";

        public string DisplayName => string.IsNullOrWhiteSpace(FullName) ? UserName : FullName;
    }
}
