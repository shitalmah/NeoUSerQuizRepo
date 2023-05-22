using MediatR;
using Microsoft.EntityFrameworkCore;
using QuizApp_API.Data;
using QuizApp_API.Model;
namespace QuizApp_API.CQRS.Quiz_attempt.Queries
{
    public class GetAllQuiz : IRequest<List<Quiz_Attempt>>
    {
        public class GetAllQuizHandler : IRequestHandler<GetAllQuiz, List<Quiz_Attempt>>
        {
            private readonly USerDbContext _context;
            public GetAllQuizHandler(USerDbContext context)
            {
                _context = context;
            }
            public async Task<List<Quiz_Attempt>> Handle(GetAllQuiz query, CancellationToken cancellationToken)
            {
                var productList = await _context.quiz_Attempts.ToListAsync();
                if (productList == null)
                {
                    return null;
                }
                return productList.ToList();
            }
        }
    }
   
}
