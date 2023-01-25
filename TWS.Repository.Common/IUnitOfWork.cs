using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWS.Repository.Common
{
    public interface IUnitOfWork : IDisposable
    {
        public Task Commit();

        public IManufacturerRepository ManufacturerRepository { get; set; }

        public IProductRepository ProductRepository { get; set; }
    }
}
