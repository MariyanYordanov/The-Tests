using System.Security.Claims;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Contains extension methods for handling ClaimsPrincipal objects.
    /// </summary>
    public static class ClaimsPrincipalExtension
    {
        /// <summary>
        /// Gets the identifier of the user from the ClaimsPrincipal.
        /// </summary>
        /// <param name="user">The ClaimsPrincipal object.</param>
        /// <returns>The identifier of the user.</returns>
        public static string Id(this ClaimsPrincipal user)
            => user.FindFirstValue(ClaimTypes.NameIdentifier);

        /// <summary>
        /// Checks whether the user is an administrator.
        /// </summary>
        /// <param name="user">The ClaimsPrincipal object.</param>
        /// <returns>True if the user is an administrator, otherwise false.</returns>
        public static bool IsAdmin(this ClaimsPrincipal user)
           => user.IsInRole("Administrator");
    }
}
