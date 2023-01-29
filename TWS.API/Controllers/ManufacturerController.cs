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
        [Route("/manufacturer")]
        public async Task<IManufacturer> GetManufacturerById(string id)
        {
            Guid entityId = new Guid(id);
            return await ManufacturerService.GetManufacturerById(entityId);
        }

        [HttpGet]
        [Route("/manufacturer-all")]
        public async Task<IEnumerable<IManufacturer>> GetAllManufacturers()
        {
            return await ManufacturerService.GetAllManufacturers();
        }

        [HttpGet]
        [Route("/manufacturer-paged")]
        public async Task<IEnumerable<IManufacturer>> GetPagedManufacturers(int pageSize, int pageNumber)
        {
            Paging pagingParams = new Paging();
            pagingParams.PageNumber = pageNumber;
            pagingParams.PageSize = pageSize;
            return await ManufacturerService.GetPagedManufacturers(pagingParams);
        }

        [HttpGet]
        [Route("/manufacturer-sorted")]
        public async Task<IEnumerable<IManufacturer>> GetSortedManufacturers(string sortBy)
        {;
            Sort sort = new Sort();
            sort.SortBy = sortBy;
            return await ManufacturerService.GetSortedManufacturers(sort);
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

        [HttpDelete]
        [Route("/delete-manufacturer")]
        public async Task DeleteManufacturer(Guid id)
        {
            await ManufacturerService.DeleteManufacturer(id);
        }

        [HttpGet]
        [Route("/search-manufacturer")]
        public async Task<IEnumerable<IManufacturer>> GetSearchManufacturers(string property, string searchPhrase)
        {
            Search search= new Search();
            search.Property = property;
            search.SearchPhrase = searchPhrase;
            return await ManufacturerService.GetSearchManufacturers(search);
        }

    }
}