using Application.DTOs.ToDoList;
using Application.Features.ToDoList.Requests.Commands;
using Application.Features.ToDoList.Requests.Queries;
using Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ToDoListsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ToDoListsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<List<ToDoListDto>>> Get()
        {
            var toDoLists = await _mediator.Send(new GetToDoListsQuery());
            return Ok(toDoLists);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<List<ToDoListDto>>> Get(int id)
        {
            var toDoLists = await _mediator.Send(new GetToDoListQuery() { Id = id });
            return Ok(toDoLists);
        }

        [Route("currentUser")]
        [HttpGet]
        public async Task<ActionResult<List<ToDoListDto>>> GetCurrentUserLists()
        {
            var toDoLists = await _mediator.Send(new GetCurrentUserToDoListsQuery());
            return Ok(toDoLists);
        }

        [Route("currentUser/{id}")]
        [HttpGet]
        public async Task<ActionResult<ToDoListDto>> GetCurrentUserList(int id)
        {
            var toDoList = await _mediator.Send(new GetCurrentUserToDoListQuery() { Id = id });
            return Ok(toDoList);
        }

        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] CreateToDoListDto createToDoListDto)
        {
            var command = new CreateToDoListCommand { CreateToDoListDto = createToDoListDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateToDoListDto updateToDoListDto)
        {
            var command = new UpdateToDoListCommand { UpdateToDoListDto = updateToDoListDto };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteToDoListCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }

    }
}
