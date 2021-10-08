﻿using System.Collections.Generic;

using TechTestM1.BusinessLogic.DataModels;

using Xunit;

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
        }
    }
}
