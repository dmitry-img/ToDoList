using Application.Contracts.Persistence;
using Application.DTOs.ToDoList;
using Application.Exceptions;
using Application.Features.ToDoList.Requests.Queries;
using AutoMapper;
using MediatR;

namespace Application.Features.ToDoList.Handlers.Queries
{
    public class GetCurrentUserToDoListQueryHandler : IRequestHandler<GetCurrentUserToDoListQuery, ToDoListDto>
    {
        private readonly IToDoListRepository _toDoListRepository;
        private readonly IMapper _mapper;

        public GetCurrentUserToDoListQueryHandler(IToDoListRepository toDoListRepository, IMapper mapper)
        {
            _toDoListRepository = toDoListRepository;
            _mapper = mapper;
        }

        public async Task<ToDoListDto> Handle(GetCurrentUserToDoListQuery request, CancellationToken cancellationToken)
        {
            var currentUserToDolist = await _toDoListRepository.GetCurrentUserToDoListAsync(request.Id);

            if (currentUserToDolist == null)
                throw new NotFoundException(nameof(currentUserToDolist), request.Id);

            return _mapper.Map<ToDoListDto>(currentUserToDolist);
        }
    }
}
