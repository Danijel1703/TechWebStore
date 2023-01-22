using TWS.Model.Common;

namespace TWS.Model
{
    public class Product : IProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int InStockQty { get; set; } 
    }
}