using System.ComponentModel.DataAnnotations;
using static TheTests.Core.ErrorMessages; 

namespace TheTests.Core.Models.Result
{
    /// <summary>
    /// The model for the result.
    /// </summary>
    public class ResultModel
    {
        /// <summary>
        /// The unique identifier for the result.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The unique identifier for the question.
        /// </summary>
        public int QuestionId { get; set; }

        /// <summary>
        /// The unique identifier for the answer.
        /// </summary>
        public int AnswerId { get; set; }

        /// <summary>
        /// The unique identifier for the test.
        /// </summary>
        public int TestId { get; set; }

        /// <summary>
        /// The unique identifier for the user.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// The unique identifier for the user.
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }
}
