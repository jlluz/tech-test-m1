using System.Collections.Generic;

namespace TechTestM1.BusinessLogic.DataModels
{
    public class ShoppingCart
    {
        private List<OrderItem> cartItems;

        internal List<OrderItem> CartItems { get => cartItems; set => cartItems = value; }

        public decimal TotalOrder { get; set; }
    }
}
