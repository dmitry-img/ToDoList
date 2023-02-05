using Application.DTOs.ToDoItem;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ToDoItem.Requests.Queries
{
    public class GetToDoItemQuery : IRequest<ToDoItemDto>
    {
        public int Id { get; set; }
    }
}
