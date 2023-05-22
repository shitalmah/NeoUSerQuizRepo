using QuickQuestionBank.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace QuizApp_API.Model
{
    public class QuizQuestions_Attempt:BaseEntity
    {
       public string QuestionText { get; set; }
        public int  QuizId { get; set; }

        [ForeignKey(nameof(QuizId))]
        public Quiz_Attempt Quiz_Attempt { get; set; }

        public decimal Marks { get; set; }

        public string SortOrder { get; set; }
        public string ComplexityLevel { get; set; }


    }
}
