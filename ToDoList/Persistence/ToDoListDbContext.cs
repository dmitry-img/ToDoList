using Application.Contracts.Identity;
using Domain.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class ToDoListDbContext : DbContext
    {
        public DbSet<ToDoItemEntity> ToDoItems { get; set; }
        public DbSet<ToDoListEntity> ToDoLists { get; set; }
        private readonly ICurrentUserService _currentUser;

        public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options, ICurrentUserService currentUser) : base(options)
        {
            _currentUser = currentUser;
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseAuditableEntity>())
            {

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = DateTime.UtcNow;
                    entry.Entity.IsDeleted = false;
                    entry.Entity.CreatedBy = _currentUser.GetId();
                }

                if(entry.State == EntityState.Modified)
                {
                    entry.Entity.LastModifiedAt = DateTime.UtcNow;
                    entry.Entity.LastModifiedBy = _currentUser.GetId();
                }

                if (entry.State == EntityState.Deleted)
                {
                    entry.Entity.DeletedAt = DateTime.UtcNow;
                    entry.Entity.IsDeleted = true;
                    entry.Entity.DeletedBy= _currentUser.GetId();

                    entry.State = EntityState.Modified;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
