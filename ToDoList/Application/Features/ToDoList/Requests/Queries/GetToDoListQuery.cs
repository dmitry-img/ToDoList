using Application.DTOs.ToDoList;
using MediatR;

namespace Application.Features.ToDoList.Requests.Queries
{
    public class GetToDoListQuery : IRequest<ToDoListDto>
    {
        public int Id { get; set; }
    }
}
