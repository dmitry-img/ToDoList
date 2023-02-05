using Application.DTOs.Common;
using Application.DTOs.ToDoItem;

namespace Application.DTOs.ToDoList
{
    public class ToDoListDto : BaseDto
    {
        public string? Title { get; set; }
        public IReadOnlyList<ToDoItemDto>? Items { get; set; }
        public bool IsDeleted { get; set; }
    }
}
