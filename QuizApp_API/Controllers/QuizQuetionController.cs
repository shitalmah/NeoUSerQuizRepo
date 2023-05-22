using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizApp_API.CQRS.Quiz_attempt.Queries;
using QuizApp_API.CQRS.User.Queries;

namespace QuizApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizQuetionController : ControllerBase
    {

        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();


        [HttpGet]
        public async Task<IActionResult> GetQuiz()
        {

            return Ok(await Mediator.Send(new GetAllQuiz()));
        }
    }
}
