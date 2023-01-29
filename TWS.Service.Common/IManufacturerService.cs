using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.Model;
using TWS.Model.Common;

namespace TWS.Service.Common
{
    public interface IManufacturerService
    {
        public Task<IEnumerable<IManufacturer>> GetAllManufacturers();
        public Task AddManufacturer(IManufacturer manufacturer);
        public Task DeleteManufacturer(Guid id);
        public Task UpdateManufacturer(Guid id, IManufacturer manufacturer);
        public Task<IEnumerable<IManufacturer>> GetPagedManufacturers(IPaging paging);
        public Task<IEnumerable<IManufacturer>> GetSortedManufacturers(ISort sort);
        public Task<IManufacturer> GetManufacturerById(Guid id);
        public Task<IEnumerable<IManufacturer>> GetSearchManufacturers(ISearch search);

    }
}
