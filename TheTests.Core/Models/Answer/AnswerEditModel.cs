using System.ComponentModel.DataAnnotations;
using static TheTests.Core.ErrorMessages;

namespace TheTests.Core.Models.Answer
{
    /// <summary>
    /// Модел за редактиране на отговор.
    /// </summary>
    public class AnswerEditModel
    {
        /// <summary>
        /// Идентификатор на отговора.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Текст на отговора.
        /// </summary>
        [Required(ErrorMessage = RequierdField)]
        public string Text { get; set; } = string.Empty;

        /// <summary>
        /// The answer is correct.
        /// </summary>
        public bool IsCorrect { get; set; }

        /// <summary>
        /// The question id.
        /// </summary>
        public int QuestionId{ get; set; }
}
}

