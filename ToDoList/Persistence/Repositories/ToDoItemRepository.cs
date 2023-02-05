using Application.Contracts.Persistence;
using Domain.Entities;

namespace Persistence.Repositories
{
    public class ToDoItemRepository : GenericRepository<ToDoItemEntity>, IToDoItemRepository
    {
        private readonly ToDoListDbContext _context;
        public ToDoItemRepository(ToDoListDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
