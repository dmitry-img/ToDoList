using Application.DTOs.Common;
using Domain.Enums;

namespace Application.DTOs.ToDoItem
{
    public class ToDoItemDto : BaseDto
    {
        public int ToDoListId { get; set; }

        public string? Title { get; set; }

        public string? Note { get; set; }
        public DateTime? RemindAt { get; set; }

        public PriorityLevel Priority { get; set; }
        public bool IsDeleted { get; set; }
    }
}
