using CmsSystem.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using SmsSystem.Application.Repositories.Customer;

namespace CmsSystem.Persistence.Repository.Customer
{
    public class CustomerWriteRepository:WriteRepository<Domain.Entities.Customer>,ICustomerWriteRepository
    {
        public CustomerWriteRepository(DataContext context) : base(context)
        {
        }
    }
}
