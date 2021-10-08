namespace TechTestM1.BusinessLogic.DataModels
{
    public class OrderItem
    {
        public Sku Sku { get; set; }
        public int Qty { get; set; }
        public decimal BulkUnitPrice { get; set; }

        public OrderItem() { }
    }
}
