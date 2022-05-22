using System.Linq.Expressions;
using CmsSystem.Domain.Entities.Common;
using CmsSystem.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using SmsSystem.Application.Repositories;

namespace CmsSystem.Persistence.Repository
{
    public class ReadRepository<T>: IReadRepository<T> where T : BaseEntity
    {
        private readonly DataContext _context;

        public ReadRepository(DataContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }


        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query =  Table.Where(method);
            if(!tracking) query = query.AsNoTracking();
            return query;
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);

        }


        public async Task<T> GetById(string id,bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking) query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));
        }
    }
}
