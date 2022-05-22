using CmsSystem.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace SmsSystem.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get;  }
    }
}
