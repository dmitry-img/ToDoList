using Application.Contracts.Persistence;
using Application.Exceptions;
using Application.Features.ToDoItem.Requests.Commands;
using MediatR;

namespace Application.Features.ToDoItem.Handles.Commands
{
    public class DeleteToDoItemCommandHandler : IRequestHandler<DeleteToDoItemCommand, Unit>
    {
        private readonly IToDoItemRepository _toDoItemRepository;

        public DeleteToDoItemCommandHandler(IToDoItemRepository toDoItemRepository)
        {
            _toDoItemRepository = toDoItemRepository;
        }

        public async Task<Unit> Handle(DeleteToDoItemCommand request, CancellationToken cancellationToken)
        {
            var toDoListEntity = await _toDoItemRepository.GetAsync(request.Id);

            if (toDoListEntity == null)
                throw new NotFoundException(nameof(toDoListEntity), request.Id);

            await _toDoItemRepository.DeleteAsync(toDoListEntity);

            return Unit.Value;
        }
    }
}
