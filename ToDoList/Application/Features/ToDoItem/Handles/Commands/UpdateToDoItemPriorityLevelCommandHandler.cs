using Application.Contracts.Persistence;
using Application.Exceptions;
using Application.Features.ToDoItem.Requests.Commands;
using AutoMapper;
using MediatR;

namespace Application.Features.ToDoItem.Handles.Commands
{
    public class UpdateToDoItemPriorityLevelCommandHandler : IRequestHandler<UpdateToDoItemPriorityLevelCommand, Unit>
    {
        private readonly IToDoItemRepository _toDoItemRepository;
        private readonly IMapper _mapper;

        public UpdateToDoItemPriorityLevelCommandHandler(IToDoItemRepository toDoItemRepository, IMapper mapper)
        {
            _toDoItemRepository = toDoItemRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateToDoItemPriorityLevelCommand request, CancellationToken cancellationToken)
        {
            var toDoItemEntity = await _toDoItemRepository.GetAsync(request.UpdateToDoItemPriorityLevelDto.Id);

            if (toDoItemEntity == null)
                throw new NotFoundException(nameof(toDoItemEntity), request.UpdateToDoItemPriorityLevelDto.Id);

            _mapper.Map(request.UpdateToDoItemPriorityLevelDto, toDoItemEntity);
            await _toDoItemRepository.UpdateAsync(toDoItemEntity);

            return Unit.Value;
        }
    }
}
