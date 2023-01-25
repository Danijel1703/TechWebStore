using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TWS.DAL;
using TWS.DAL.Entities;
using TWS.Model;
using TWS.Model.Common;
using TWS.Repository.Common;

namespace TWS.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly TWSContext _dbContext;

        private readonly IMapper _mapper;

        public ProductRepository(TWSContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<IProduct>> GetAll()
        {
            var entities = await _dbContext.Set<ProductEntity>().ToListAsync();
            IEnumerable<IProduct> products = _mapper.Map<IEnumerable<Product>>(entities);
            return products;
        }

        public async Task<IProduct> GetById(Guid id)
        {
            var entity = await _dbContext.Set<ProductEntity>().FindAsync(id);
            Product product = _mapper.Map<Product>(entity);
            return product;
        }

        public async Task Create(IProduct entity)
        {
            ProductEntity product = _mapper.Map<ProductEntity>(entity);
            _dbContext.Set<ProductEntity>().Add(product);
            await Task.FromResult(product);
        }

        public async Task Delete(Guid id)
        {
            IProduct entity = await GetById(id);
            _dbContext.Set<IProduct>().Remove(entity);
            await Task.FromResult(entity);
        }

        public async Task Update(Guid id, IProduct entity)
        {
            _dbContext.Set<IProduct>().Attach(entity);
            _dbContext.Set<IProduct>().Update(entity);
            await Task.FromResult(entity);
        }
    }
}