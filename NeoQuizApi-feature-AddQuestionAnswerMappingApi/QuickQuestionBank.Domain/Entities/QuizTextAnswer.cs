using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuestionBank.Domain.Entities
{
    public  class QuizTextAnswer:BaseEntity
    {
        public Guid QuestionTypeId { get; set; }

        [ForeignKey(nameof(QuestionTypeId))]
        public QuestionType QuestionType { get; set; }

        public Guid QuizId { get; set; }

        [ForeignKey(nameof(QuizId))]
        public Quiz Quiz_Attempt { get; set; }


        public string AnswerText{ get; set; }
    }
}
