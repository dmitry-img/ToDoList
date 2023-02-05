using Application.Contracts.Persistence;
using Application.Exceptions;
using Application.Features.ToDoItem.Requests.Commands;
using AutoMapper;
using MediatR;

namespace Application.Features.ToDoItem.Handles.Commands
{
    public class UpdateToDoItemCommandHandler : IRequestHandler<UpdateToDoItemCommand, Unit>
    {
        private readonly IToDoItemRepository _toDoItemRepository;
        private readonly IMapper _mapper;

        public UpdateToDoItemCommandHandler(IToDoItemRepository toDoItemRepository, IMapper mapper)
        {
            _toDoItemRepository = toDoItemRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateToDoItemCommand request, CancellationToken cancellationToken)
        {
            var toDoItemEntity = await _toDoItemRepository.GetAsync(request.UpdateToDoItemDto.Id);

            if (toDoItemEntity == null)
                throw new NotFoundException(nameof(toDoItemEntity), request.UpdateToDoItemDto.Id);

            _mapper.Map(request.UpdateToDoItemDto, toDoItemEntity);
            await _toDoItemRepository.UpdateAsync(toDoItemEntity);

            return Unit.Value;
        }
    }
}
