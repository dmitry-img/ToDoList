using Application.DTOs.ToDoList;
using Application.Responses;
using MediatR;

namespace Application.Features.ToDoList.Requests.Commands
{
    public class CreateToDoListCommand : IRequest<BaseCommandResponse>
    {
        public CreateToDoListDto CreateToDoListDto { get; set; }
    }
}
