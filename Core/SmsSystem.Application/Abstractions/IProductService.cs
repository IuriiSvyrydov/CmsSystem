using CmsSystem.Domain.Entities;

namespace SmsSystem.Application.Abstractions
{
    public interface IProductService
    {
       Task< IEnumerable<Product>> GetProducts();
    }
}
