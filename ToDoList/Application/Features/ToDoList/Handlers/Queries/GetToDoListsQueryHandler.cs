using Application.Contracts.Persistence;
using Application.DTOs.ToDoList;
using Application.Exceptions;
using Application.Features.ToDoList.Requests.Queries;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ToDoList.Handlers.Queries
{
    public class GetToDoListsQueryHandler : IRequestHandler<GetToDoListsQuery, List<ToDoListDto>>
    {
        private readonly IToDoListRepository _toDoListRepository;
        private readonly IMapper _mapper;

        public GetToDoListsQueryHandler(IToDoListRepository toDoListRepository, IMapper mapper)
        {
            _toDoListRepository = toDoListRepository;
            _mapper = mapper;
        }

        public async Task<List<ToDoListDto>> Handle(GetToDoListsQuery request, CancellationToken cancellationToken)
        {
            var toDoLists = await _toDoListRepository.GetListsWithDetailsAsync();
            return _mapper.Map<List<ToDoListDto>>(toDoLists);
        }
    }
}
