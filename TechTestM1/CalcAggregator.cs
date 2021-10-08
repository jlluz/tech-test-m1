using System.Collections.Generic;

using TechTestM1.BusinessLogic.DataModels;

namespace TechTestM1
{
    public class CalcAggregator
    {
        private ShoppingCart shoppingCart;
        private List<PromotionA> promotions;

        public static decimal CalcOrderValue(ShoppingCart shoppingCart, params object[] promotions)
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
                            if (promotion is PromotionA)
                            {
                                if (((PromotionA)promotion).Status)
                                {
                                    int pQty = ((PromotionA)promotion).Qty;

                                    if (cartitem.Qty > 0 && pQty > 0)
                                    {
                                        int xQty = cartitem.Qty / pQty;
                                        int rQty = cartitem.Qty % pQty;

                                        switch (cartitem.Sku.Id)
                                        {
                                            case 'A':
                                            case 'B':
                                                retVal += (xQty * pQty) + (rQty * cartitem.Sku.Price);
                                                break;

                                            case 'C':
                                            case 'D':
                                                if (cartitem.BulkUnitPrice > 0)
                                                {
                                                    retVal += (xQty * pQty) + (rQty * cartitem.BulkUnitPrice);
                                                }
                                                else
                                                {
                                                    retVal += (xQty * pQty) + (rQty * cartitem.Sku.Price);
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

            return retVal;
        }
    }
}
