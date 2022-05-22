using CmsSystem.Domain.Entities.Common;

namespace SmsSystem.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> model);
        bool RemoveAsync(T model);
        Task<bool> RemoveAsync(string id);
        bool RemoveRangeAsync(List<T>model);
        bool UpdateAsync(T model);
        Task<int> SaveChangesAsync();
    }
}
