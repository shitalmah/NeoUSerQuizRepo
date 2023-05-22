using Microsoft.EntityFrameworkCore;
using QuizApp_API.Model;

namespace QuizApp_API.Data
{
    public class USerDbContext:DbContext
    {
        public USerDbContext(DbContextOptions<USerDbContext> options):base(options)
        {
            
        }


        public DbSet<User_Admin>  User_Admins { get; set; }

        public DbSet<Quiz_Attempt>   quiz_Attempts { get; set; }

        public DbSet<QuizQuestions_Attempt>  quizQuestions_Attempts { get; set; }

       
    }
}
