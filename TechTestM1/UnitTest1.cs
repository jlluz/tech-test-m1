using System.Collections.Generic;

using TechTestM1.BusinessLogic.DataModels;

namespace TechTestM1
{
    public class UnitTest1
    {
        public List<PromotionA> Promotions { get; set; }

        public UnitTest1()
        {
            var promotionA = new PromotionA();
            promotionA.Sku.Id = 'A';
            promotionA.Sku.Price = 50;
            promotionA.Qty = 3;
            promotionA.BulkPrice = 130;
            this.Promotions.Add(promotionA);

            var promotionB = new PromotionA();
            promotionB.Sku.Id = 'B';
            promotionB.Sku.Price = 30;
            promotionB.Qty = 2;
            promotionB.BulkPrice = 45;
            this.Promotions.Add(promotionB);

            var promotionC = new PromotionA();
            promotionC.Sku.Id = 'C';
            promotionC.Sku.Price = 20;
            promotionC.Qty = 1;
            promotionC.BulkPrice = 20;
            this.Promotions.Add(promotionC);

            var promotionD = new PromotionA();
            promotionD.Sku.Id = 'D';
            promotionD.Sku.Price = 15;
            promotionD.Qty = 1;
            promotionD.BulkPrice = 15;
            this.Promotions.Add(promotionD);
        }

    }
}
