using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheTests.Infrastructure.Models;

namespace TheTests.Infrastructure.Data.SeedDb
{
    internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var data = new SeedData();
            builder.HasData(
            [
                data.Admin,
                data.LoggedUser,
                data.GuestUser
            ]);
        }
    }
}
