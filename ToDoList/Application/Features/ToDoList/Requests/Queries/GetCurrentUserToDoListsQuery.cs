using Application.DTOs.ToDoList;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ToDoList.Requests.Queries
{
    public class GetCurrentUserToDoListsQuery : IRequest<List<ToDoListDto>>
    {
    }
}
