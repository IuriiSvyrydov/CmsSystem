using CmsSystem.Persistence.Context;
using SmsSystem.Application.Repositories.Product;

namespace CmsSystem.Persistence.Repository.Product
{
    public class ProductWriteRepository:WriteRepository<Domain.Entities.Product>, IProductWriteRepository
    {
        public ProductWriteRepository(DataContext context) : base(context)
        {
        }
    }
}
