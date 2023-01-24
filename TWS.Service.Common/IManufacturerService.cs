using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.Model.Common;

namespace TWS.Service.Common
{
    public interface IManufacturerService
    {
        public Task<IEnumerable<IManufacturer>> GetAllManufacturers();
        public Task AddManufacturer(IManufacturer manufacturer);
    }
}
