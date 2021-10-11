
using System.Collections.Generic;

using TechTestM1.BusinessLogic.DataModels;

namespace TechTestM1
{
    public class CalcAggregator
    {

        public static decimal CalcOrderValue(ShoppingCart shoppingCart, IEnumerable<PromotionA> promotions)
        {
            decimal retVal = 0;

            if (shoppingCart != null)
            {
                foreach (var cartitem in shoppingCart.CartItems)
                {
                    if (promotions != null)
                    {
                        foreach (var promotion in promotions)
                        {
                            if (promotion is PromotionA promotiona)
                            {
                                if (((PromotionA)promotion).Status)
                                {
                                    int pQty = ((PromotionA)promotion).Qty;

                                    if (cartitem.Qty > 0 && pQty > 0)
                                    {
                                        int xQty = cartitem.Qty / pQty;
                                        int rQty = cartitem.Qty % pQty;

                                        if (promotion.Sku.Id == cartitem.Sku.Id)
                                        {
                                            switch (promotion.Sku.Id)
                                            {
                                                case 'A':
                                                case 'B':
                                                    retVal += (xQty * promotion.BulkPrice) + (rQty * cartitem.Sku.Price);
                                                    break;

                                                case 'C':
                                                case 'D':
                                                    if (cartitem.BulkUnitPrice > 0)
                                                    {
                                                        retVal += (xQty * promotion.BulkPrice) + (rQty * cartitem.BulkUnitPrice);
                                                    }
                                                    else
                                                    {
                                                        retVal += (xQty * promotion.BulkPrice) + (rQty * cartitem.Sku.Price);
                                                    }
                                                    break;

                                                default:
                                                    break;
                                            }
                                        }

                                    }
                                }
                            }

                        }
                    }
                }

            }

            return retVal;
        }
    }
}
