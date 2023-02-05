using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class ToDoItemEntity : BaseAuditableEntity
    {
        public int ToDoListId { get; set; }

        public string? Title { get; set; }

        public string? Note { get; set; }
        public DateTime? RemindAt { get; set; }

        public PriorityLevel Priority { get; set; }
        public ToDoListEntity ToDoList { get; set; }
    }
}
