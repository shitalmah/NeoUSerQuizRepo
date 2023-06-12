using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickQuestionBank.Application.Features.QuizQuestion.Commands;
using QuickQuestionBank.Application.Interfaces.IRepository;
using QuickQuestionBank.Domain.DTOs;
using QuickQuestionBank.Domain.Entities;

namespace QuickQuestionBank.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizSaveController : ControllerBase
    {
        private readonly IQuizOptionTextAnswerReporsitory quizOptionTextAnswerReporsitory;
        public QuizSaveController(IQuizOptionTextAnswerReporsitory quizOptionTextAnswer)
        {
            this.quizOptionTextAnswerReporsitory= quizOptionTextAnswer;
        }

        [HttpPost]
        [Route("save")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Post(QuizOptionAnswer model)
        {
            var response = await quizOptionTextAnswerReporsitory.SaveAsyncOptions(model);
            return Ok(response);
        }

    }
}
