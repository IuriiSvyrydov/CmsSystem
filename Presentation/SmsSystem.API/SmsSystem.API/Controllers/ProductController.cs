using CmsSystem.Domain.Entities;

namespace SmsSystem.API.Controllers
{
    //[ApiVersion("1.0")]
    [Route(ApiRoutes.BaseRoute)]
    [ApiController]
    public class ProductController : BaseController
    {
       private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;
        public ProductController( IProductWriteRepository productWriteRepository,IProductReadRepository productReadRepository, 
            IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository)
        {
           _productReadRepository = productReadRepository;
           _orderWriteRepository = orderWriteRepository;
           _customerWriteRepository = customerWriteRepository;
           _productWriteRepository = productWriteRepository;
        }

        [HttpGet]
      
        public async Task AddProducts()
        {
            var customerId = Guid.NewGuid();
            await _customerWriteRepository.AddAsync(new Customer() {Id = customerId, Name = "Ferro5"});
            await _orderWriteRepository.AddAsync(new Order() {Description = "Description 1", Address = "Address1",CustomerId = customerId});
            await _orderWriteRepository.SaveChangesAsync();
        }
        [HttpGet]
         [Route(ApiRoutes.Products.GetProductById)]
        public async Task<IActionResult> GetProduct(string id)
        {
           // var productGuid = Guid.Parse(id);

           var product = await _productReadRepository.GetById(id);
           return Ok(product);
        }

    }
}
