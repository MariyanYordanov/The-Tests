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
        /// Флаг, показващ дали отговорът е верен.
        /// </summary>
        public bool IsCorrect { get; set; }
    }
}

