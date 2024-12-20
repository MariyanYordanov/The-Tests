using TheTests.Core.Models.AppUser;

namespace TheTests.Core.Contracts
{
    public interface IUserService
    {
        Task<IEnumerable<AppUserModel>> GetAllUsersAsync();
    }
}
