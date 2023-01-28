using Microsoft.AspNetCore.Mvc;
using TWS.Model;
using TWS.Model.Common;
using TWS.Repository.Common;
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

        [HttpGet]
        [Route("/manufacturers-all")]
        public async Task<IEnumerable<IManufacturer>> GetAllManufacturers()
        {
            return await ManufacturerService.GetAllManufacturers();
        }

        [HttpGet]
        [Route("/manufacturers-paged")]
        public async Task<IEnumerable<IManufacturer>> GetPagedManufacturers(int pageSize, int pageNumber)
        {
            Paging pagingParams = new Paging();
            pagingParams.PageNumber = pageNumber;
            pagingParams.PageSize = pageSize;
            return await ManufacturerService.GetPagedManufacturers(pagingParams);
        }

        [HttpPost]
        [Route("/add-manufacturer")]
        public async Task AddManufacturer(Manufacturer manufacturer)
        {
            await ManufacturerService.AddManufacturer(manufacturer);
        }

        [HttpPut]
        [Route("/update-manufacturer")]
        public async Task UpdateManufacturer(Guid id, Manufacturer manufacturer)
        {
            await ManufacturerService.UpdateManufacturer(id, manufacturer);
        }

        [HttpDelete(Name = "/delete-manufacturer")]
        public async Task DeleteManufacturer(Guid id)
        {
            await ManufacturerService.DeleteManufacturer(id);
        }

    }
}