﻿using QuickQuestionBank.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickQuestionBank.Domain.Entities {
    public class QuestionAnswerMapping : BaseEntity
    {
        public  Guid QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        public  QuizQuestion QuizQuestion { get; set; }
        public string OptionText { get; set; }
        public string IsCorrectAnswer { get; set; }
        public int SortOrder { get; set; }
    }
}
