using Domain.Entities;

namespace Application.Contracts.Persistence
{
    public interface IToDoListRepository : IGenericRepository<ToDoListEntity>
    {
        Task<List<ToDoListEntity>?> GetListsWithDetailsAsync();
        Task<ToDoListEntity?> GetListWithDetailsAsync(int id);
        Task<List<ToDoListEntity>?> GetCurrentUserToDoListsAsync();
        Task<ToDoListEntity?> GetCurrentUserToDoListAsync(int id);
    }
}
