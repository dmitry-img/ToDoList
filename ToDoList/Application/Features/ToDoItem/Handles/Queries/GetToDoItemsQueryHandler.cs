using Application.Contracts.Persistence;
using Application.DTOs.ToDoItem;
using Application.Features.ToDoItem.Requests.Queries;
using AutoMapper;
using MediatR;

namespace Application.Features.ToDoItem.Handles.Queries
{
    public class GetToDoItemsQueryHandler : IRequestHandler<GetToDoItemsQuery, List<ToDoItemDto>>
    {
        private readonly IToDoItemRepository _toDoItemRepository;
        private readonly IMapper _mapper;

        public GetToDoItemsQueryHandler(IToDoItemRepository toDoItemRepository, IMapper mapper)
        {
            _toDoItemRepository = toDoItemRepository;
            _mapper = mapper;
        }

        public async Task<List<ToDoItemDto>> Handle(GetToDoItemsQuery request, CancellationToken cancellationToken)
        {
            var toDoItems = await _toDoItemRepository.GetAllAsync();
            return _mapper.Map<List<ToDoItemDto>>(toDoItems);
        }
    }
}
