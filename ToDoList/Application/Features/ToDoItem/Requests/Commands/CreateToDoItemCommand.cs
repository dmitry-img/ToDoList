
using Application.DTOs.ToDoItem;
using Application.Responses;
using MediatR;

namespace Application.Features.ToDoItem.Requests.Commands
{
    public class CreateToDoItemCommand : IRequest<BaseCommandResponse>
    {
        public CreateToDoItemDto CreateToDoItemDto { get; set; }
    }
}
