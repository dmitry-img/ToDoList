using Application.Contracts.Identity;
using Application.Contracts.Persistence;
using Application.DTOs.ToDoList;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class ToDoListRepository : GenericRepository<ToDoListEntity>, IToDoListRepository
    {
        private readonly ToDoListDbContext _context;
        private readonly ICurrentUserService _currentUserService;
        public ToDoListRepository(ToDoListDbContext context, ICurrentUserService currentUserService) : base(context)
        {
            _context = context;
            _currentUserService = currentUserService;
        }

        public async Task<List<ToDoListEntity>?> GetListsWithDetailsAsync()
        {
            return await _context.ToDoLists.Include(x => x.Items).ToListAsync();
        }

        public async Task<ToDoListEntity?> GetListWithDetailsAsync(int id)
        {
            return await _context.ToDoLists.Include(x => x.Items).FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task<List<ToDoListEntity>?> GetCurrentUserToDoListsAsync()
        {
            var id = _currentUserService.GetId();
            return await _context.ToDoLists.Where(x => x.CreatedBy == id).ToListAsync();
        }

        public async Task<ToDoListEntity?> GetCurrentUserToDoListAsync(int id)
        {
            var userId = _currentUserService.GetId();
            return await _context.ToDoLists.Where(x => x.CreatedBy == userId).FirstOrDefaultAsync(l => l.Id == id);
        }
    }
}
