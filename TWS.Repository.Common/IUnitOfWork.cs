using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWS.Repository.Common
{
    public interface IUnitOfWork : IDisposable
    {
        public void Commit();

        public IManufacturerRepository ManufacturerRepository { get; set; }
    }
}
