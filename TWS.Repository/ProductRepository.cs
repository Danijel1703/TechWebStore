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
            ProductEntity entity = _dbContext.Set<ProductEntity>().Find(id);
            _dbContext.Set<ProductEntity>().Remove(entity);
            await Task.FromResult(entity);
        }

        public async Task Update(Guid id, IProduct entity)
        {
            ProductEntity newEntity = _mapper.Map<ProductEntity>(entity);
            ProductEntity existingEntity = _dbContext.Set<ProductEntity>().Where(entity => entity.Id == id).FirstOrDefault();
            existingEntity.Name = newEntity.Name;
            existingEntity.Description = newEntity.Description;
            existingEntity.Price = newEntity.Price;
            existingEntity.SKU= newEntity.SKU;
            await Task.FromResult(existingEntity);
        }

        public async Task<IEnumerable<IProduct>> GetPagedEntries(IPaging paging)
        {
            int skip = paging.PageSize * (paging.PageNumber - 1);
            IEnumerable<ProductEntity> entities = await _dbContext.Set<ProductEntity>().Skip(skip).Take(paging.PageSize).ToListAsync();
            IEnumerable<Product> result = _mapper.Map<IEnumerable<Product>>(entities);
            return result;
        }

        public async Task<IEnumerable<IProduct>> GetSortedEntries(ISort sort)
        {
            var entries = _dbContext.Set<ProductEntity>();
            IEnumerable<ProductEntity> entities;
            switch (sort.SortBy)
            {
                case "name_asc":
                    entities = await entries.OrderBy(entity => entity.Name).ToListAsync(); break;
                case "name_desc":
                    entities = await entries.OrderByDescending(entity => entity.Name).ToListAsync(); break;
                case "price_asc":
                    entities = await entries.OrderBy(entity => entity.Price).ToListAsync(); break;
                case "price_desc":
                    entities = await entries.OrderByDescending(entity => entity.Price).ToListAsync(); break;
                default:
                    entities = await entries.OrderBy(entity => entity.Name).ToListAsync(); break;
            }
            IEnumerable<IProduct> result = _mapper.Map<IEnumerable<Product>>(entities);
            return result;
        }

        public async Task<IEnumerable<IProduct>> GetSearchEntries(ISearch search)
        {
            var entries = _dbContext.Set<ProductEntity>();
            IEnumerable<ProductEntity> entities;
            switch (search.Property)
            {
                case "name":
                    entities = await entries.Where(entity => entity.Name.Contains(search.SearchPhrase)).ToListAsync(); break;
                case "description":
                    entities = await entries.Where(entity => entity.Description.Contains(search.SearchPhrase)).ToListAsync(); break;
                default:
                    entities = await entries.OrderBy(entity => entity.Name).ToListAsync(); break;
            }
            IEnumerable<IProduct> result = _mapper.Map<IEnumerable<Product>>(entities);
            return result;
        }
    }
}