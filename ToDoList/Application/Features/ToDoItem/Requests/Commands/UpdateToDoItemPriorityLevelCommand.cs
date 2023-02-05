using Application.DTOs.ToDoItem;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ToDoItem.Requests.Commands
{
    public class UpdateToDoItemPriorityLevelCommand : IRequest<Unit>
    {
        public UpdateToDoItemPriorityLevelDto UpdateToDoItemPriorityLevelDto { get; set; }
    }
}
