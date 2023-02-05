using Application.Contracts.Persistence;
using Application.DTOs.ToDoList;
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
    public class GetCurrentUserToDoListsQueryHandler : IRequestHandler<GetCurrentUserToDoListsQuery, List<ToDoListDto>>
    {
        private readonly IToDoListRepository _toDoListRepository;
        private readonly IMapper _mapper;

        public GetCurrentUserToDoListsQueryHandler(IToDoListRepository toDoListRepository, IMapper mapper)
        {
            _toDoListRepository = toDoListRepository;
            _mapper = mapper;
        }
        public async Task<List<ToDoListDto>> Handle(GetCurrentUserToDoListsQuery request, CancellationToken cancellationToken)
        {
            var lists = await _toDoListRepository.GetCurrentUserToDoListsAsync();
            return _mapper.Map<List<ToDoListDto>>(lists);
        }
    }
}
