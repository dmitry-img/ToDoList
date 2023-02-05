using Application.Contracts.Persistence;
using Application.DTOs.ToDoItem;
using Application.Exceptions;
using Application.Features.ToDoItem.Requests.Queries;
using AutoMapper;
using MediatR;

namespace Application.Features.ToDoItem.Handles.Queries
{
    public class GetToDoItemQueryHandler : IRequestHandler<GetToDoItemQuery, ToDoItemDto>
    {
        private readonly IToDoItemRepository _toDoItemRepository;
        private readonly IMapper _mapper;

        public GetToDoItemQueryHandler(IToDoItemRepository toDoItemRepository, IMapper mapper)
        {
            _toDoItemRepository = toDoItemRepository;
            _mapper = mapper;
        }

        public async Task<ToDoItemDto> Handle(GetToDoItemQuery request, CancellationToken cancellationToken)
        {
            var toDoItem = await _toDoItemRepository.GetAsync(request.Id);
            if (toDoItem is null)
                throw new NotFoundException(nameof(toDoItem),request.Id);

            return _mapper.Map<ToDoItemDto>(toDoItem);
        }
    }
}
