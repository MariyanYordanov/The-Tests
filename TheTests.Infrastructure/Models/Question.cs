﻿using System.ComponentModel.DataAnnotations;
using static TheTests.Infrastructure.Constants;

namespace TheTests.Infrastructure.Models
{
    public class Question
    {
        public int Id { get; set; }

        [Required]
        [StringLength(MaxPoints)]
        public int Points { get; set; }

        [Required]
        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public AnswerType АnswerType { get; set; }

        public ICollection<Answer> Answers { get; set; } = [];

        public int TestId { get; set; }
        public Test Test { get; set; } = null!;
    }
}

