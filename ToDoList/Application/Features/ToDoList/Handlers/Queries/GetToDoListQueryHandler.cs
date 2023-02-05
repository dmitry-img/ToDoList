using Application.Contracts.Persistence;
using Application.DTOs.ToDoList;
using Application.Exceptions;
using Application.Features.ToDoList.Requests.Queries;
using AutoMapper;
using MediatR;

namespace Application.Features.ToDoList.Handlers.Queries
{
    public class GetToDoListQueryHandler : IRequestHandler<GetToDoListQuery, ToDoListDto>
    {
        private readonly IToDoListRepository _toDoListRepository;
        private readonly IMapper _mapper;

        public GetToDoListQueryHandler(IToDoListRepository toDoListRepository, IMapper mapper)
        {
            _toDoListRepository = toDoListRepository;
            _mapper = mapper;
        }

        public async Task<ToDoListDto> Handle(GetToDoListQuery request, CancellationToken cancellationToken)
        {
            var toDoList = await _toDoListRepository.GetListWithDetailsAsync(request.Id);

            if(toDoList is null)
                throw new NotFoundException(nameof(toDoList), request.Id);

            return _mapper.Map<ToDoListDto>(toDoList);
        }
    }
}
