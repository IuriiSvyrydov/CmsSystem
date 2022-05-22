using CmsSystem.Persistence.Context;
using SmsSystem.Application.Repositories.Order;

namespace CmsSystem.Persistence.Repository.Order
{
    public class OrderWriteRepository:WriteRepository<Domain.Entities.Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(DataContext context) : base(context)
        {
        }
    }
}
