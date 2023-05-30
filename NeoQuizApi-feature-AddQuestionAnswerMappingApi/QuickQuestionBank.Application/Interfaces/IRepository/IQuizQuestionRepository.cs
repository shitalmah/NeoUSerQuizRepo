﻿using QuickQuestionBank.Domain.Entities;

namespace QuickQuestionBank.Application.Interfaces.IRepository
{
    public interface IQuizQuestionRepository
    {
       // Task<Guid> DeleteAsync(Quiz entity);

        Task<Guid> DeleteAsync(Guid id);
        Task<IReadOnlyList<QuizQuestion>> GetAllAsync();
        Task<QuizQuestion> GetByIdAsync(Guid id);
        Task<QuizQuestion> SaveAsync(QuizQuestion entity);
        Task<List<QuizQuestion>> GetQuetiobQuizId(Guid Quizid);
    }
}
