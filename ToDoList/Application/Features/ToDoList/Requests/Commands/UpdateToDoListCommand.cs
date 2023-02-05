using Application.DTOs.ToDoList;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ToDoList.Requests.Commands
{
    public class UpdateToDoListCommand : IRequest<Unit>
    {
        public UpdateToDoListDto UpdateToDoListDto { get; set; }
    }
}
