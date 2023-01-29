using TWS.Model.Common;

namespace TWS.Service.Common
{
    public interface IProductService
    {
        Task<IEnumerable<IProduct>> GetAllProducts();
        Task CreateProduct(IProduct product);
        Task DeleteProduct(Guid id);
        Task UpdateProduct(Guid id, IProduct product);
        Task<IEnumerable<IProduct>> GetPagedProducts(IPaging paging);
        Task<IEnumerable<IProduct>> GetSortedProducts(ISort sort);
        public Task<IProduct> GetProductById(Guid id);
        public Task<IEnumerable<IProduct>> GetSearchProducts(ISearch search);
    }
}