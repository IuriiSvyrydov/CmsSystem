using CmsSystem.Domain.Entities.Common;

namespace CmsSystem.Domain.Entities
{
    public class Customer: BaseEntity
    {
        private readonly List<Order> _orders;

        public Customer()
        {
            _orders = new List<Order>();
        }

        public string Name { get; set; }
        public IEnumerable<Order> Orders => _orders;
    }
}
