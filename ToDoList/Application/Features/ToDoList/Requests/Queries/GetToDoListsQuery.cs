using Application.DTOs.ToDoList;
using MediatR;

namespace Application.Features.ToDoList.Requests.Queries
{
    public class GetToDoListsQuery : IRequest<List<ToDoListDto>>
    {
    }
}
