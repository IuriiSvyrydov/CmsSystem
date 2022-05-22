using CmsSystem.Domain.Entities.Common;
using CmsSystem.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SmsSystem.Application.Repositories;

namespace CmsSystem.Persistence.Repository
{
    public class WriteRepository<T>: IWriteRepository<T> where T : BaseEntity
    {
        private readonly DataContext _context;

        public WriteRepository(DataContext context)
        {
            _context = context;
            
        }

        public DbSet<T> Table=>_context.Set<T>();
        public  async Task<bool> AddAsync(T model)
        {
          EntityEntry<T> entity =   await Table.AddAsync(model);
          return entity.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> model)
        {
            await Table.AddRangeAsync(model);
            return true;
        }

        public bool RemoveAsync(T model)
        {
            EntityEntry < T > entity = Table.Remove(model);
            return entity.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            T model = await Table.FirstOrDefaultAsync(t => t.Id == Guid.Parse(id));
            return RemoveAsync(model);
        }

        public bool RemoveRangeAsync(List<T> model)
        {
            Table.RemoveRange(model);
            return true;
        }

        public bool UpdateAsync(T model)
        {
            EntityEntry<T> entity = Table.Update(model);
            return entity.State == EntityState.Modified;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
