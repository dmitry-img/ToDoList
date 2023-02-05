using Domain.Common;

namespace Domain.Entities
{
    public class ToDoListEntity : BaseAuditableEntity
    {
        public string? Title { get; set; }
        public IReadOnlyList<ToDoItemEntity> Items { get; private set; } = new List<ToDoItemEntity>();
    }
}
