using Microsoft.EntityFrameworkCore;

namespace SmsSystem.Application.Repositories
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> Table { get; set; }
    }
}
