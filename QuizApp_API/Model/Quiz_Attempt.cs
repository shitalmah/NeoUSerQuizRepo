using QuickQuestionBank.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace QuizApp_API.Model
{
    public class Quiz_Attempt:BaseEntity
    {
        public string QuizTitle { get; set; }
        public string QuizExpiryDate { get; set; }
        public decimal QuizMarks { get; set; }
        public DateTime Quiz_Duration { get; set; }
        public string QuestionsPerPage { get; set; }
        public string PassingCriteriaInPercentage { get; set; }

        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User_Admin user_admin { get; set; }

    }
}
