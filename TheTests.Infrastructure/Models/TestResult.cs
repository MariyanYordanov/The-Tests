namespace TheTests.Infrastructure.Models
{
    public class TestResult
    {
        public int Id { get; set; }

        public int TestId { get; set; }
        public Test Test { get; set; } = null!;

        public string UserId { get; set; }
        public AppUser User { get; set; } = null!;

        public int Score { get; set; }

        public DateTime CompletedAt { get; set; }
    }
}

