﻿using QuickQuestionBank.Domain.DTOs;
using QuickQuestionBank.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace QuickQuestionBank.Domain.Entities
{
    public class User_Admin: BaseEntity
    { 

       // public string FullName { get; set; }
            
       // public string Password { get; set; }

        public string Email { get; set; }

        public Guid QuizId { get; set; }

        [ForeignKey(nameof(QuizId))]
        public Quiz Quiz_Attempt { get; set; }

        public string Link { get; set; }

       // public String  UserType { get; set; }

       


    }
}
