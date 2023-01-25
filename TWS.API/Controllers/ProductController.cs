using Microsoft.AspNetCore.Mvc;
using TWS.Model;
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

        [HttpPost(Name = "AddProduct")]
        public async Task CreateProduct(Product product)
        {
            await ProductService.CreateProduct(product);
        }

        [HttpPut(Name = "UpdateProduct")]
        public async Task UpdateProduct(Guid id, Product product)
        {
            await ProductService.UpdateProduct(id, product);
        }

        [HttpDelete(Name = "DeleteProduct")]
        public async Task DeleteProduct(Guid id)
        {
            await ProductService.DeleteProduct(id);
        }

    }
}