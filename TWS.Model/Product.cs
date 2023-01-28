using TWS.Model.Common;

namespace TWS.Model
{
    public class Product : IProduct
    {
        public Guid Id { get; set; }
        public string Abrv { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string SKU { get; set; }
        public Guid ManufacturerId { get; set; }
    }
}