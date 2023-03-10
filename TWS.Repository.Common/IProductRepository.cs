using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.Model.Common;

namespace TWS.Repository.Common
{
    public interface IProductRepository : IGenericRepository<IProduct>
    {
        Task<IEnumerable<IProduct>> GetSortedEntries(ISort sort);
        Task<IEnumerable<IProduct>> GetSearchEntries(ISearch search);
    }
}
