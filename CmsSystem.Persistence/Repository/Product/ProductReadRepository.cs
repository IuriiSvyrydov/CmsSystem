
using CmsSystem.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using SmsSystem.Application.Repositories.Product;

namespace CmsSystem.Persistence.Repository.Product
{
    public class ProductReadRepository:ReadRepository<Domain.Entities.Product>, IProductReadRepository
    {
        public ProductReadRepository(DataContext context) : base(context)
        {
        }
    }
}
