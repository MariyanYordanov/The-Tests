using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheTests.Infrastructure.Models;

namespace TheTests.Infrastructure.Data.SeedDb
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            var data = new SeedData();
            builder.HasData(
            [
                data.FirstQuestion,
                data.SecondQuestion,
                data.ThirdQuestion
            ]);
        }
    }
}
