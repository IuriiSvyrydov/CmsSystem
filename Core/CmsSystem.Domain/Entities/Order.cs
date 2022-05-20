using CmsSystem.Domain.Entities.Common;

namespace CmsSystem.Domain.Entities
{
    public class Order: BaseEntity
    {
        private readonly List<Product> _products;

        public Order()
        {
            _products = new List<Product>();
        }

        public string Description { get; set; }
        public string Address { get; set; }
        public IEnumerable<Product> Products => _products;
        public string CustomerId  { get; set; }
        public Customer Customer { get; set; }
    }
}
