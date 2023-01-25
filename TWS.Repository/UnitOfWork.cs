using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.DAL;
using TWS.Repository.Common;

namespace TWS.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private TWSContext _dbContext { get; set; }
        public IManufacturerRepository ManufacturerRepository { get; set; }

        public IProductRepository ProductRepository { get; set; }

        public UnitOfWork(TWSContext dbContext, IMapper mapper) 
        { 
            _dbContext = dbContext;
            ManufacturerRepository = new ManufacturerRepository(dbContext, mapper);
            ProductRepository= new ProductRepository(dbContext, mapper);
        }

        public async Task Commit()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
