using Microsoft.AspNetCore.Mvc;
using TWS.Model;
using TWS.Model.Common;
using TWS.Service;
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


        [HttpGet]
        [Route("/product-all")]
        public async Task<IEnumerable<IProduct>> GetAllProducts()
        {
            return await ProductService.GetAllProducts();
        }

        [HttpGet]
        [Route("/product-paged")]
        public async Task<IEnumerable<IProduct>> GetPagedProducts(int pageSize, int pageNumber)
        {
            Paging pagingParams = new Paging();
            pagingParams.PageNumber = pageNumber;
            pagingParams.PageSize = pageSize;
            return await ProductService.GetPagedProducts(pagingParams);
        }

        [HttpPost(Name = "/add-product")]
        public async Task CreateProduct(Product product)
        {
            await ProductService.CreateProduct(product);
        }

        [HttpPut(Name = "/update-product")]
        public async Task UpdateProduct(Guid id, Product product)
        {
            await ProductService.UpdateProduct(id, product);
        }

        [HttpDelete(Name = "/delete-product")]
        public async Task DeleteProduct(Guid id)
        {
            await ProductService.DeleteProduct(id);
        }

    }
}