using Domain.Entities;

namespace Application.Contracts.Persistence
{
    public interface IToDoItemRepository : IGenericRepository<ToDoItemEntity>
    {
    }
}
