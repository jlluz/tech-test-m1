using System;

namespace TechTestM1.BusinessLogic.DataModels
{
    public class Sku
    {
        public char Id
        {
            get
            {
                return Char.ToUpper(Id);
            }
            set
            {
                Id = value;
            }
        }

        public decimal Price { get; set; }

        public Sku() { }

    }
}
