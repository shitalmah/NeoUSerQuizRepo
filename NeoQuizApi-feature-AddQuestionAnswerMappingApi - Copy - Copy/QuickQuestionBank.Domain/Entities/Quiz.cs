using QuickQuestionBank.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickQuestionBank.Domain.Entities
{
    public class Quiz : BaseEntity
    {
        public string QuizTitle { get; set; }
        public DateTime QuizExpiryDate { get; set; }
        public decimal QuizMarks { get; set; }
        public string QuestionsPerPage { get; set; }
        public string PassingCriteriaInPercentage { get; set; }

        public Guid userid { get; set; }

        [ForeignKey(nameof(userid))]
        public User_Admin User_Admin { get; set; }
        public string timeDuration { get; set; }
    }
}
