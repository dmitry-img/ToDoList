using Application.DTOs.ToDoItem;
using MediatR;


namespace Application.Features.ToDoItem.Requests.Queries
{
    public class GetToDoItemsQuery : IRequest<List<ToDoItemDto>>
    {
    }
}
