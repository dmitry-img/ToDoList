using Application.Contracts.Persistence;
using Application.Features.ToDoList.Requests.Commands;
using Application.Responses;
using AutoMapper;
using MediatR;
using Domain.Entities;

namespace Application.Features.ToDoList.Handlers.Commands
{
    public class CreateToDoListCommandHandler : IRequestHandler<CreateToDoListCommand, BaseCommandResponse>
    {
        private readonly IToDoListRepository _toDoListRepository;
        private readonly IMapper _mapper;

        public CreateToDoListCommandHandler(IToDoListRepository toDoListRepository, IMapper mapper)
        {
            _toDoListRepository = toDoListRepository;
            _mapper = mapper;
        }

        public async Task<BaseCommandResponse> Handle(CreateToDoListCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var toDoList = _mapper.Map<ToDoListEntity>(request.CreateToDoListDto);
            var createdToDoList = await _toDoListRepository.AddAsync(toDoList);
            
            response.Success = createdToDoList != null;
            if(!response.Success) 
            {
                response.Errors.Add("Creation of the 'toDoItem' failed!");
            }

            return response; 
        }
    }
}
