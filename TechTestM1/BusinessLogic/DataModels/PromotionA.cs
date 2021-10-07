namespace TechTestM1.BusinessLogic.DataModels
{
    public class PromotionA : Promotion
    {
        public Sku Sku { get; set; }
        public int Qty { get; set; }
        public decimal BulkPrice { get; set; }
        public bool Status { get; set; }

        public PromotionA() { }
    }
}
