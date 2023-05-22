using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizApp_API.CQRS.Quiz_attempt.Queries;
using QuizApp_API.CQRS.User.Queries;

namespace QuizApp_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuizQuetionController : ControllerBase
    {

        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();


        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuizId(int id)
        {

            var quiz = await Mediator.Send(new GetQuizByUserid { id = id });
            int QUIZid = quiz[0].Id;
            return Ok(QUIZid);
        }




        [HttpGet]
        public async Task<IActionResult> GetQuetionsbyId(int id)
        {

           // var quiz = await Mediator.Send(new GetQuetionbyquizId { id = id });
            
            return Ok(await Mediator.Send(new GetQuetionbyquizId { id = id }));
        }
    }
}
