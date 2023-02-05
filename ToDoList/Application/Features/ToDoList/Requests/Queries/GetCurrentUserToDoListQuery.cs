using Application.DTOs.ToDoList;
using MediatR;

namespace Application.Features.ToDoList.Requests.Queries
{
    public class GetCurrentUserToDoListQuery : IRequest<ToDoListDto>
    {
        public int Id { get; set; }
    }
}
