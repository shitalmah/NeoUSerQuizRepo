using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QuickQuestionBank.Application.CQRS.Quiz_attempt.Queries;
using QuickQuestionBank.Application.Features.QuizQuestion.Commands;
using QuickQuestionBank.Application.Features.QuizQuestion.Queries;
using QuickQuestionBank.Application.Interfaces.IRepository;
using QuickQuestionBank.Domain.DTOs;

namespace QuickQuestionBank.API.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class QuizQuestionController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IQuizQuestionRepository _quizQuestionRepository;
        public QuizQuestionController(IMediator mediator, IQuizQuestionRepository quizQuestionRepository)
        {
            this._mediator = mediator;
            this._quizQuestionRepository= quizQuestionRepository;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get(Guid id) =>
            Ok(await _mediator.Send(new GetQuizQuestionQuery { Id = id }));



        [HttpGet]
        [Route("GetQuetiobQuizId")]
        public async Task<IActionResult> GetQuetiobQuizId(Guid Quizid) =>
            Ok(await _quizQuestionRepository.GetQuetiobQuizId(Quizid));


        [HttpGet]
        [Route("get-all")]
        public async Task<IActionResult> GetAll() =>
            Ok(await _mediator.Send(new GetAllQuizQuestionQuery()));

        [HttpPost]
        [Route("save")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Post(QuizQuestionDTO model)
        {
            var response = await _mediator.Send(new CreateQuizQuestionCommand { model = model });
            return Ok(response);
        }

        [HttpDelete("id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(Guid id)
        {
            var response = await _mediator.Send(new DeleteQuizQuestionQuery { Id = id });
            if (response.Count == 0)
            {
                return NotFound();
            }
            return Ok(response);
        }
    }
}
