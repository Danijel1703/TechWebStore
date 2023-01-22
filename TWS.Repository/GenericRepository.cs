using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.DAL;
using TWS.Repository.Common;

namespace TWS.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly TWSContext _dbContext; 

        public GenericRepository(TWSContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            IQueryable<TEntity> entities = _dbContext.Set<TEntity>();
            return await entities.ToListAsync();
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            return entity;
        }

        public virtual async Task Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            await Task.FromResult(entity);
        }

        public virtual async Task Delete(Guid id)
        {
            TEntity entity = await GetById(id);
            _dbContext.Set<TEntity>().Remove(entity);
            await Task.FromResult(entity);
        }

        public virtual async Task Update(Guid id, TEntity entity)
        {
            _dbContext.Set<TEntity>().Attach(entity);
            _dbContext.Set<TEntity>().Update(entity);
            await Task.FromResult(entity);
        }
    }
}
