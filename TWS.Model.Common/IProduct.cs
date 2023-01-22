namespace TWS.Model.Common
{
    public interface IProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int InStockQty { get; set; }
    }
}