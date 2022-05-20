using SmsSystem.Application.Abstractions;

namespace SmsSystem.API.Controllers
{
    //[ApiVersion("1.0")]
    [Route(ApiRoutes.BaseRoute)]
    [ApiController]
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products =await _productService.GetProducts();
            return Ok(products);
        }
    }
}
