using Domain.Enums;

namespace Application.DTOs.ToDoItem
{
    public class CreateToDoItemDto
    {
        public int ToDoListId { get; set; }

        public string? Title { get; set; }

        public string? Note { get; set; }

        public PriorityLevel Priority { get; set; }
    }
}
