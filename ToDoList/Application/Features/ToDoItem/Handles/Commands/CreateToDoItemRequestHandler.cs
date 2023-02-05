using Application.Contracts.Persistence;
using Application.Features.ToDoItem.Requests.Commands;
using Application.Responses;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.ToDoItem.Handles.Commands
{
    public class CreateToDoItemRequestHandler : IRequestHandler<CreateToDoItemCommand, BaseCommandResponse>
    {
        private readonly IToDoItemRepository _toDoItemRepository;
        private readonly IMapper _mapper;

        public CreateToDoItemRequestHandler(IToDoItemRepository toDoItemRepository, IMapper mapper)
        {
            _toDoItemRepository = toDoItemRepository;
            _mapper = mapper;
        }

        public async Task<BaseCommandResponse> Handle(CreateToDoItemCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var toDoItem = _mapper.Map<ToDoItemEntity>(request.CreateToDoItemDto);
            var createdToDoItem = await _toDoItemRepository.AddAsync(toDoItem);

            response.Success = createdToDoItem != null;
            if (!response.Success)
            {
                response.Errors.Add("Creation of the 'toDoList' failed!");
            }

            return response;
        }
    }
}
