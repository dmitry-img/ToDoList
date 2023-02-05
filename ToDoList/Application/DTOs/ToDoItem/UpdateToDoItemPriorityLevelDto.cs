using Application.DTOs.Common;
using Domain.Enums;

namespace Application.DTOs.ToDoItem
{
    public class UpdateToDoItemPriorityLevelDto : BaseDto
    {
        public PriorityLevel Priority { get; set; }
    }
}
