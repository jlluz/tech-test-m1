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


        public double Price { get; set; }

        public Sku() { }

    }
}
