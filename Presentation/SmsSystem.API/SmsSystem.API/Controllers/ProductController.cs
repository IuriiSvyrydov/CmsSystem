
namespace SmsSystem.API.Controllers
{
    //[ApiVersion("1.0")]
    [Route(ApiRoutes.BaseRoute)]
    [ApiController]
    public class ProductController : BaseController
    {
       private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;
   
        public ProductController( IProductWriteRepository productWriteRepository,IProductReadRepository productReadRepository)
        {
           _productReadRepository = productReadRepository; ;
           _productWriteRepository = productWriteRepository;
        }

        [HttpGet]
      
        public async Task<IActionResult> GetAllProducts()
        {
            return Ok(await _productReadRepository.GetAll().ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(CreateProductViewModel product)
        {
            await _productWriteRepository.AddAsync(new Product()
            {
                Name = product.Name,
                InStock = product.InStock,
                Price = product.Price
            });
            await _productWriteRepository.SaveChangesAsync();
            return Ok((int)HttpStatusCode.Created);
        }
        [HttpGet]
         [Route(ApiRoutes.Products.GetProductById)]
        public async Task<IActionResult> GetProduct(string id)
        {
           // var productGuid = Guid.Parse(id);

           var product = await _productReadRepository.GetById(id);
           return Ok(product);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductViewModel product)
        {
            Product updateProduct = await _productReadRepository.GetById(product.Id);
            updateProduct.Name = product.Name;
            updateProduct.InStock = product.InStock;
            updateProduct.Price = product.Price;
            await _productWriteRepository.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        [Route(ApiRoutes.Products.IdRoute)]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productWriteRepository.RemoveAsync(id);
            await _productWriteRepository.SaveChangesAsync();
            return Ok();
        }


    }
}
