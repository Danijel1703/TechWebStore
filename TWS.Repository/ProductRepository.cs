using Microsoft.EntityFrameworkCore;
using TWS.DAL;
using TWS.Model.Common;
using TWS.Repository.Common;

namespace TWS.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly TWSContext _dbContext;

        public ProductRepository(TWSContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<IProduct>> GetAll()
        {
            IQueryable<IProduct> entities = _dbContext.Set<IProduct>();
            return await entities.ToListAsync();
        }

        public async Task<IProduct> GetById(Guid id)
        {
            var entity = await _dbContext.Set<IProduct>().FindAsync(id);
            return entity;
        }

        public async Task Create(IProduct entity)
        {
            _dbContext.Set<IProduct>().Add(entity);
            await Task.FromResult(entity);
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