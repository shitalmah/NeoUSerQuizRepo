using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizApp_API.CQRS.User.Queries;
using QuizApp_API.Model;

namespace QuizApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
       
        
        [HttpGet("{email}")]
        public async Task<IActionResult> GetByEmail(string email)
        {
        
            return Ok(await Mediator.Send(new GetUserByEmail { Email = email }));
        }

    }
}
