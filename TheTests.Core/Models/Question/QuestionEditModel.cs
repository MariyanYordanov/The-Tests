using System.ComponentModel.DataAnnotations;
using static TheTests.Core.ModelConstants;
using static TheTests.Core.ErrorMessages;
using TheTests.Core.Models.Answer;

namespace TheTests.Core.Models.Question
{
    /// <summary>
    /// Модел за редактиране на въпрос.
    /// </summary>
    public class QuestionEditModel
    {
        /// <summary>
        /// Идентификатор на въпроса.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Текст на въпроса.
        /// </summary>
        [Required(ErrorMessage = RequierdField)]
        public string Text { get; set; } = string.Empty;

        /// <summary>
        /// Брой точки за този въпрос.
        /// </summary>
        [Required(ErrorMessage = RequierdField)]
        [Range(1, 100, ErrorMessage = RequieredLength)]
        public int Points { get; set; }

        /// <summary>
        /// Списък с отговори към въпроса.
        /// </summary>
        public List<AnswerEditModel> Answers { get; set; } = new List<AnswerEditModel>();
    }
}

