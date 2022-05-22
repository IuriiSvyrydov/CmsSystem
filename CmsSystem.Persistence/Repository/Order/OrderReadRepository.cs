using System.Linq.Expressions;
using CmsSystem.Domain.Entities;
using CmsSystem.Persistence.Context;
using CmsSystem.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using SmsSystem.Application.Repositories.Order;

namespace CmsSystem.Persistence.Repository.Order
{
    public class OrderReadRepository : ReadRepository<Domain.Entities.Order>,IOrderReadRepository
    {
        public OrderReadRepository(DataContext context) : base(context)
        {
        }
    }

}
