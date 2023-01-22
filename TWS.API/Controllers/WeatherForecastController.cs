using Microsoft.AspNetCore.Mvc;
using TWS.Model.Common;
using TWS.Service.Common;

namespace TWS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public IProductService ProductService { get; }

        [HttpGet(Name = "GetAllProducts")]
        public async Task<IEnumerable<IProduct>> GetAllProducts()
        {
            return await ProductService.GetAllProducts();
        }
    }
}