using AutoMapper;
using MediatR;
using QuickQuestionBank.Application.Features.QuizQuestion.Queries;
using QuickQuestionBank.Application.Helpers;
using QuickQuestionBank.Application.Interfaces.IRepository;
using QuickQuestionBank.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuestionBank.Application.Features.QuizQuestion.Handlers
{
    public class GetQuetiobQuizIdHandlers : IRequestHandler<GetQuetiobQuizId, Response<List<QuizQuestionDTO>>>
    {
        private readonly IQuizQuestionRepository _repository;
        private readonly IMapper _mapper;

        public GetQuetiobQuizIdHandlers(IQuizQuestionRepository repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        public async Task<Response<List<QuizQuestionDTO>>> Handle(GetQuetiobQuizId request, CancellationToken cancellationToken)
        {
            //Fetch date from database
            IReadOnlyList<QuickQuestionBank.Domain.Entities.QuizQuestion> result = await _repository.GetQuetiobQuizId(request.QuizId);
            List<QuizQuestionDTO> list = new();
            //Map
            foreach (var quiz in result)
            {
                QuizQuestionDTO quizDTO = new();
                QuizQuestionDTO.MapEntityToDto(quiz, quizDTO);
                list.Add(quizDTO);
            }
            //Map using automapper or custom mapper
            //QuizQuestionDTO quizdto = new();
            //QuizQuestionDTO.MapEntityToDto(result, quizdto);


            return new Response<List<QuizQuestionDTO>>
            {
                Data = list,
                Message = "Question Types found!",
                Count = list.Count
            };
           
        }
    }
}
