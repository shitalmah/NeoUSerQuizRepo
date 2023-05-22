using MediatR;
using Microsoft.EntityFrameworkCore;
using QuizApp_API.Data;
using QuizApp_API.Model;
using System.Collections.Generic;

namespace QuizApp_API.CQRS.Quiz_attempt.Queries
{
    public class GetQuizByUserid : IRequest<List<Quiz_Attempt>>
    {
        public int id { get; set; }
        public class GetQuizByUseridHandler : IRequestHandler<GetQuizByUserid, List<Quiz_Attempt>>
        {
         
            private readonly USerDbContext _context;
            public GetQuizByUseridHandler(USerDbContext context)
            {
                _context = context;
            }
            public async Task<List<Quiz_Attempt>> Handle(GetQuizByUserid query, CancellationToken cancellationToken)
            {
               // List<Quiz_Attempt> quiz_Attempts = _context.quiz_Attempts.Include(r => r.UserId).Where(r => r.UserId == TxtRole.Text)
                  List <Quiz_Attempt> quiz_Attempts = _context.quiz_Attempts.Where(a => a.UserId == query.id).ToList();                                 
                  return quiz_Attempts;
           
            }
        }
    }
  
}
