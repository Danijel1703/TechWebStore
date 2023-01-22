using TWS.Model.Common;
using TWS.Model;
using TWS.Repository.Common;
using TWS.Repository;

namespace TWS.Service
{
    public class DIModule : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IProduct>().To<Product>();
            Bind(typeof(IGenericRepository<>)).To(typeof(GenericRepository<>));
            Bind<IProductRepository>().To<ProductRepository>();
        }
    }
}