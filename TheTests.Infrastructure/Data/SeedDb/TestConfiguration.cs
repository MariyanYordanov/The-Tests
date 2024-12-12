using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheTests.Infrastructure.Data.SeedDb;
using TheTests.Infrastructure.Models;

namespace TheTests.Infrastructure.Data.SeedDb
{
    public class TestConfiguration : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            var data = new SeedData();
            builder.HasData(
            [
                data.FirstTest,
                data.SecondTest,
                data.ThirdTest
            ]);
        }
    }
}
