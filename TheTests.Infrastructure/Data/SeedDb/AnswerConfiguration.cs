using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheTests.Infrastructure.Models;

namespace TheTests.Infrastructure.Data.SeedDb
{
    internal class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            var data = new SeedData();
            builder.HasData(
            [
                data.FirstAnswer,
                data.SecondAnswer,
                data.ThirdAnswer
            ]);
        }
    }
}
