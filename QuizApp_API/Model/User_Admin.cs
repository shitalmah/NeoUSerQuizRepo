using QuickQuestionBank.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace QuizApp_API.Model
{
    public class User_Admin: BaseEntity
    { 

        public string FullName { get; set; }
            
        public string Password { get; set; }

        public string Email { get; set; }

        public String  UserType { get; set; }
 



    }
}
