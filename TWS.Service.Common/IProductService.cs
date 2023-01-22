using TWS.Model.Common;

namespace TWS.Service.Common
{
    public interface IProductService
    {
        Task<IEnumerable<IProduct>> GetAllProducts();
    }
}