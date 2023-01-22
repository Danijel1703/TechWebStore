using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.Repository.Common;
using TWS.Model.Common;
using TWS.Service.Common;

namespace TWS.Service
{
    public class ProductService : IProductService
    {
        private IProductRepository _repository;
        public ProductService(IProductRepository repository) 
        {
            _repository = repository;
        }

        public async Task<IEnumerable<IProduct>> GetAllProducts() 
        {
            return await _repository.GetAll();
        }
    }
}
