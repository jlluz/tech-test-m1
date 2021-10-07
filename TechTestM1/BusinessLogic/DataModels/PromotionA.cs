namespace TechTestM1.BusinessLogic.DataModels
{
    public class PromotionA : Promotion
    {
        public int Id { get; set; }
        public Sku Sku { get; set; }
        public int Qty { get; set; }
        public double BulkPrice { get; set; }
        public bool Status { get; set; }

        public PromotionA() { }
    }
}
