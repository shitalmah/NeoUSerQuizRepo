using QuickQuestionBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuestionBank.Application.Interfaces.IRepository
{
    public interface IQuizOptionTextAnswerReporsitory
    {

        Task<QuizOptionAnswer> GetOptionsByIdAsync(Guid id);

      
        Task<List<QuizOptionAnswer>> GetAllOptions();
    
        Task<QuizOptionAnswer> SaveAsyncOptions(QuizOptionAnswer entity);
        Task<QuizTextAnswer> GetTextByIdAsync(Guid id);


        Task<List<QuizTextAnswer>> GetAllText();

        Task<QuizTextAnswer> SaveAsynText(QuizTextAnswer entity);
    }
}
