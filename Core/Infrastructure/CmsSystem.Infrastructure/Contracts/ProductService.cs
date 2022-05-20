using CmsSystem.Domain.Entities;
using SmsSystem.Application.Abstractions;

namespace CmsSystem.Infrastructure.Contracts
{
    public class ProductService: IProductService
    {
        public async Task<IEnumerable<Product> >GetProducts() => new List<Product>
        {
            new(){Id = Guid.NewGuid(),Name = "Product1",InStock = 10,Price = 3400},
            new(){Id = Guid.NewGuid(),Name = "Product2",InStock = 15,Price = 3500},
            new(){Id = Guid.NewGuid(),Name = "Product3",InStock = 30,Price = 3600},
            new(){Id = Guid.NewGuid(),Name = "Product5",InStock = 50,Price = 6000},
        };

    }
}
