using TWS.Model;
using TWS.Model.Common;

namespace TWS.Repository.Common
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(Guid id);
        Task Create(TEntity entity);
        Task Update(Guid id, TEntity entity);
        Task Delete(Guid id);
        Task<IEnumerable<TEntity>> GetPagedEntries(IPaging paging);
    }
}