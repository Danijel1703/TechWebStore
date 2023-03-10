using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.Model.Common;

namespace TWS.Repository.Common
{
    public interface IManufacturerRepository : IGenericRepository<IManufacturer>
    {
        Task<IEnumerable<IManufacturer>> GetSortedEntries(ISort sort);
        Task<IEnumerable<IManufacturer>> GetSearchEntries(ISearch search);
    }
}
