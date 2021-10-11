using System;

namespace TechTestM1.BusinessLogic.DataModels
{
    public class Sku
    {
        public char Id { get; set; }
        public decimal Price { get; set; }

        public Sku()
        {
            Id = Char.ToUpper(Id);
            Price = 0;
        }

    }
}
