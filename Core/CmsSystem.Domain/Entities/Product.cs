using CmsSystem.Domain.Entities.Common;

namespace CmsSystem.Domain.Entities
{
    public class Product:BaseEntity
    {
        private readonly List<Order> _orders;

        public Product()
        {
            _orders = new List<Order>();
        }
        public string  Name { get;  set; }
        public int  InStock { get;  set; }
        public decimal Price { get; set; }

        public IEnumerable<Order> Orders => _orders;
      //  private Product(){}

        public Product CreateProduct(string name, int inStock, decimal price) =>
            new() { Name = name, InStock = inStock, Price = price };
        
    }
}
