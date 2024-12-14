using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static TheTests.Infrastructure.Constants;

namespace TheTests.Infrastructure.Data.Models
{
    /// <summary>
    /// The application user entity.
    /// </summary>
    public class AppUser : IdentityUser
    {
        /// <summary>
        /// The first name of the user.
        /// </summary>
        [Required]
        [StringLength(MaxNameLength)]
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// The last name of the user.
        /// </summary>
        [Required]
        [StringLength(MaxNameLength)]
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// The full name of the user.
        /// </summary>
        public string FullName => $"{FirstName} {LastName}";

        /// <summary>
        /// The display name of the user.
        /// </summary>
        public string DisplayName => string.IsNullOrWhiteSpace(FullName) ? UserName : FullName;
    }
}
