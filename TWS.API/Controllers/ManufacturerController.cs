using Microsoft.AspNetCore.Mvc;
using TWS.Model;
using TWS.Model.Common;
using TWS.Service;
using TWS.Service.Common;

namespace TWS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManufacturerController : ControllerBase
    {
        public IManufacturerService ManufacturerService { get; set; }
        public ManufacturerController(IManufacturerService manufacturerService)
        {
            ManufacturerService = manufacturerService;
        }


        [HttpGet(Name = "GetAllManufacturers")]
        public async Task<IEnumerable<IManufacturer>> GetAllManufacturers()
        {
            return await ManufacturerService.GetAllManufacturers();
        }

        [HttpPost(Name = "AddManufacturer")] 
        public async Task AddManufacturer(Manufacturer manufacturer)
        {
            await ManufacturerService.AddManufacturer(manufacturer);
        }

    }
}