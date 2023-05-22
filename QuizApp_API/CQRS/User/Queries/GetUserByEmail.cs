using MediatR;
using QuizApp_API.Data;
using QuizApp_API.Model;
using System.Collections.Generic;

namespace QuizApp_API.CQRS.User.Queries
{
    
    public class GetUserByEmail : IRequest<User_Admin>
    {
        public string Email { get; set; }
        public class GetProductByIdQueryHandler : IRequestHandler<GetUserByEmail, User_Admin>
        {
            private readonly USerDbContext _context;
            public GetProductByIdQueryHandler(USerDbContext context)
            {
                _context = context;
            }
            public async Task<User_Admin> Handle(GetUserByEmail query, CancellationToken cancellationToken)
            {
                var user = _context.User_Admins.Where(a => a.Email == query.Email).FirstOrDefault();
                if (user == null) return null;
                return user;


            }
        }
    }
}
