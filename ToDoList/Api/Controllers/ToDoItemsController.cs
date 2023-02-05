using Application.DTOs.ToDoItem;
using Application.Features.ToDoItem.Requests.Commands;
using Application.Features.ToDoItem.Requests.Queries;
using Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ToDoItemsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ToDoItemsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<List<ToDoItemDto>>> Get()
        {
            var toDoLists = await _mediator.Send(new GetToDoItemsQuery());
            return Ok(toDoLists);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<List<ToDoItemDto>>> Get(int id)
        {
            var toDoLists = await _mediator.Send(new GetToDoItemQuery() { Id = id});
            return Ok(toDoLists);
        }

        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] CreateToDoItemDto createToDoItemDto)
        {
            var command = new CreateToDoItemCommand { CreateToDoItemDto = createToDoItemDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UpdateToDoItemDto updateToDoItemDto)
        {
            var command = new UpdateToDoItemCommand { UpdateToDoItemDto = updateToDoItemDto };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpPatch]
        public async Task<ActionResult> Patch([FromBody] UpdateToDoItemPriorityLevelDto updateToDoItemPriorityLevelDto)
        {
            var command = new UpdateToDoItemPriorityLevelCommand { UpdateToDoItemPriorityLevelDto = updateToDoItemPriorityLevelDto };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteToDoItemCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }

    }
}
