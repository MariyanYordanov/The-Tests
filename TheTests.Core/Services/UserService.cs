using Microsoft.EntityFrameworkCore;
using TheTests.Core.Contracts;
using TheTests.Core.Models.AppUser;
using TheTests.Infrastructure.Data.Common;
using TheTests.Infrastructure.Data.Models;

namespace TheTests.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository _repo;

        public async Task<IEnumerable<AppUserModel>> GetAllUsersAsync()
            => await _repo.AllReadonly<AppUser>()
            .Select(u => new AppUserModel
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName
            }).ToListAsync();
    }
}
