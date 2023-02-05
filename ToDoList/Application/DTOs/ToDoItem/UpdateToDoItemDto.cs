using Application.DTOs.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ToDoItem
{
    public class UpdateToDoItemDto : BaseDto
    {
        public string? Title { get; set; }

        public string? Note { get; set; }

        public PriorityLevel Priority { get; set; }
    }
}
