using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ToDoList
{
    public class UpdateToDoListDto : BaseDto
    {
        public string? Title { get; set; }
    }
}
