namespace TheTests.Infrastructure.Data.Models
{
    /// <summary>
    /// The result entity.
    /// </summary>
    public class Result
    {
        /// <summary>
        /// The unique identifier for the result.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The test identifier.
        /// </summary>
        public int TestId { get; set; }
        public Test Test { get; set; } = null!;

        /// <summary>
        /// The user identifier.
        /// </summary>
        public string UserId { get; set; }
        public AppUser User { get; set; } = null!;

        /// <summary>
        /// The score of the result.
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// The total number of questions in the test.
        /// </summary>
        public DateTime CompletedAt { get; set; }
    }
}

