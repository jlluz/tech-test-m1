using System.Collections.Generic;

using TechTestM1.BusinessLogic.DataModels;

using Xunit;

namespace TechTestM1
{
    public class UnitTest1
    {
        public List<PromotionA> Promotions { get; set; }

        public UnitTest1()
        {
            Promotions = new List<PromotionA>();

            var promotionA = new PromotionA
            {
                Sku = new Sku
                {
                    Id = 'A',
                    Price = 50
                },
                Qty = 3,
                BulkPrice = 130,
                Status = true // promotion is active
            };
            this.Promotions.Add(promotionA);

            var promotionB = new PromotionA
            {
                Sku = new Sku
                {
                    Id = 'B',
                    Price = 30
                },
                Qty = 2,
                BulkPrice = 45,
                Status = true
            };
            this.Promotions.Add(promotionB);

            var promotionC = new PromotionA
            {
                Sku = new Sku
                {
                    Id = 'C',
                    Price = 20
                },
                Qty = 1,
                BulkPrice = 20,
                Status = true
            };
            this.Promotions.Add(promotionC);

            var promotionD = new PromotionA
            {
                Sku = new Sku
                {
                    Id = 'D',
                    Price = 15
                },
                Qty = 1,
                BulkPrice = 15,
                Status = true
            };
            this.Promotions.Add(promotionD);
        }

        [Fact]
        public void TestScenarioA()
        {
            var shoppingCart = new ShoppingCart();

            var orderItemA = new OrderItem
            {
                Sku = new Sku
                {
                    Id = 'A',
                    Price = 50
                },
                Qty = 1,

            };

            shoppingCart.CartItems.Add(orderItemA);

            var orderItemB = new OrderItem
            {
                Sku = new Sku
                {
                    Id = 'B',
                    Price = 30
                },
                Qty = 1,

            };

            shoppingCart.CartItems.Add(orderItemB);

            var orderItemC = new OrderItem
            {
                Sku = new Sku
                {
                    Id = 'C',
                    Price = 20
                },
                Qty = 1,

            };

            shoppingCart.CartItems.Add(orderItemC);

            Assert.Equal(100, CalcAggregator.CalcOrderValue(shoppingCart, Promotions));
        }
    }
}
