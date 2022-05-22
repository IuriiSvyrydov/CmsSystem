using System.Linq.Expressions;
using CmsSystem.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using SmsSystem.Application.Repositories.Customer;

namespace CmsSystem.Persistence.Repository.Customer
{
    public class CustomerReadRepository:ReadRepository<Domain.Entities.Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(DataContext context) : base(context)
        {
        }
    }
}
