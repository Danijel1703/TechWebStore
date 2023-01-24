using Microsoft.AspNetCore.Mvc;
using TWS.Model.Common;
using TWS.Service.Common;

namespace TWS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        public IProductService ProductService { get; set; }
        public ProductController(IProductService productService)
        {
            ProductService = productService;
        }


        [HttpGet(Name = "GetAllProducts")]
        public async Task<IEnumerable<IProduct>> GetAllProducts()
        {
            return await ProductService.GetAllProducts();
        }
    }
}