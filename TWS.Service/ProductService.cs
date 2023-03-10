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
        private IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork, IProductRepository repository) 
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<IProduct>> GetAllProducts() 
        {
            return await _repository.GetAll();
        }

        public async Task CreateProduct(IProduct product)
        {
            await _unitOfWork.ProductRepository.Create(product);
            await _unitOfWork.Commit();
        }

        public async Task UpdateProduct(Guid id, IProduct product)
        {
            await _unitOfWork.ProductRepository.Update(id, product);
            await _unitOfWork.Commit();
        }

        public async Task DeleteProduct(Guid id)
        {
            await _unitOfWork.ProductRepository.Delete(id);
            await _unitOfWork.Commit();
        }

        public async Task<IEnumerable<IProduct>> GetPagedProducts(IPaging paging)
        {
            return await _repository.GetPagedEntries(paging);
        }

        public async Task<IEnumerable<IProduct>> GetSortedProducts(ISort sort)
        {
            return await _repository.GetSortedEntries(sort);
        }
        public async Task<IProduct> GetProductById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public async Task<IEnumerable<IProduct>> GetSearchProducts(ISearch search)
        {
            return await _repository.GetSearchEntries(search);
        }
    }
}
