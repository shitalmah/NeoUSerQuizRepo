using Microsoft.EntityFrameworkCore;
using QuickQuestionBank.Application.Interfaces.IRepository;
using QuickQuestionBank.Domain;
using QuickQuestionBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuestionBank.Infrastructure.Services.Repository
{
    public class QuizOptionTextAnswerReporsitory : IQuizOptionTextAnswerReporsitory
    {
        private readonly QuickQuestionDbContext _context;

        public QuizOptionTextAnswerReporsitory(QuickQuestionDbContext context)
        {
            this._context = context;
        }


        public async Task<List<QuizOptionAnswer>> GetAllOptions()
        {
            return await _context.quizOptionAnswers.ToListAsync();
        }

        public async Task<List<QuizTextAnswer>> GetAllText()
        {
            return await _context.quizTextAnswers.ToListAsync();
        }

        public async Task<QuizOptionAnswer> GetOptionsByIdAsync(Guid id)
        {
            return await _context.quizOptionAnswers.Where(q => q.Id == id).FirstOrDefaultAsync();
        }

        public async Task<QuizTextAnswer> GetTextByIdAsync(Guid id)
        {
            return await _context.quizTextAnswers.Where(q => q.Id == id).FirstOrDefaultAsync();
        }

        public async Task<QuizOptionAnswer> SaveAsyncOptions(QuizOptionAnswer entity)
        {
            if (entity.Id == default)
            {
                await _context.AddAsync(entity);
            }
            else
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<QuizTextAnswer> SaveAsynText(QuizTextAnswer entity)
        {
            if (entity.Id == default)
            {
                await _context.AddAsync(entity);
            }
            else
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
