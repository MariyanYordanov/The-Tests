using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheTests.Infrastructure.Models;

namespace TheTests.Infrastructure.Data.SeedDb
{
    public class TestCategoryConfiguration : IEntityTypeConfiguration<TestCategory>
    {
        public void Configure(EntityTypeBuilder<TestCategory> builder)
        {
            var testCategories = new SeedData();
            builder.HasData(
            [
                testCategories.FirstCategory,
                testCategories.SecondCategory,
                testCategories.ThirdCategory
            ]);
        }
    }
}
