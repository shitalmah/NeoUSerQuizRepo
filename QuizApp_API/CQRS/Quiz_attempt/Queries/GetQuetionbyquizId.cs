using MediatR;
using QuizApp_API.Data;
using QuizApp_API.Model;

namespace QuizApp_API.CQRS.Quiz_attempt.Queries
{
    public class GetQuetionbyquizId : IRequest<List<QuizQuestions_Attempt>>
    {
        public int id { get; set; }
        public class GetQuetionbyquizIddHandler : IRequestHandler<GetQuetionbyquizId, List<QuizQuestions_Attempt>>
        {

            private readonly USerDbContext _context;
            public GetQuetionbyquizIddHandler(USerDbContext context)
            {
                _context = context;
            }
            public async Task<List<QuizQuestions_Attempt>> Handle(GetQuetionbyquizId query, CancellationToken cancellationToken)
            {
                // List<Quiz_Attempt> quiz_Attempts = _context.quiz_Attempts.Include(r => r.UserId).Where(r => r.UserId == TxtRole.Text)
                List<QuizQuestions_Attempt> quiz_Attempts = _context.quizQuestions_Attempts.Where(a => a.QuizId == query.id).ToList();
                return quiz_Attempts;

            }
        }
    }
}
