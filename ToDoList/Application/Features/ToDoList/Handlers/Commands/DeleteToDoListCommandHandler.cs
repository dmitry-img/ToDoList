using Application.Contracts.Persistence;
using Application.Exceptions;
using Application.Features.ToDoList.Requests.Commands;
using AutoMapper;
using MediatR;

namespace Application.Features.ToDoList.Handlers.Commands
{
    public class DeleteToDoListCommandHandler : IRequestHandler<DeleteToDoListCommand, Unit>
    {
        private readonly IToDoListRepository _toDoListRepository;

        public DeleteToDoListCommandHandler(IToDoListRepository toDoListRepository, IMapper mapper)
        {
            _toDoListRepository = toDoListRepository;
        }

        public async Task<Unit> Handle(DeleteToDoListCommand request, CancellationToken cancellationToken)
        {
            var toDoList = await _toDoListRepository.GetAsync(request.Id);

            if (toDoList is null)
                throw new NotFoundException(nameof(toDoList), request.Id);

            await _toDoListRepository.DeleteAsync(toDoList);

            return Unit.Value;
        }
    }
}
