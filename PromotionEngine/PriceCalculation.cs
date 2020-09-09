using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class PriceCalculation : IProductService
    {
       
        public dynamic UnitPrice { get; set; }
        public dynamic ActivePromotions { get; set; }
        
        public int GetTotalPrice(List<ProductToBuy> productsListToBuy)
        {
            int totalFromPromotion = this.CalculateTotalPriceApplyingPromotion(productsListToBuy);
            int totalFromUnitPrice = this.CalculateTotalPriceApplyingUnitPrice(productsListToBuy);

            int total = totalFromPromotion + totalFromUnitPrice;
            return total;
        }


        public int CalculateTotalPriceApplyingPromotion(List<ProductToBuy> productsListToBuy)
        {
            int total = 0;
            for (int i = 0; i < ActivePromotions.Count; i++)
            {
                dynamic currentPromotion = ActivePromotions[i];
                bool isSatisfied = true;
                for (int j = 0; j < productsListToBuy.Count; j++)
                {
                    ProductToBuy product = productsListToBuy[j];

                    int currentPromotionQuantity = Convert.ToInt32(currentPromotion[product.ProuductName].Value);
                    if (currentPromotionQuantity <= product.ProductQuantity)
                    {
                        isSatisfied = isSatisfied & true;

                    }
                    else
                    {
                        isSatisfied = false;
                    }
                    if (!isSatisfied)
                    {
                        break;
                    }

                }
                if (isSatisfied)
                {

                    total += currentPromotion["Price"].Value;
                    Console.WriteLine(currentPromotion["Message"].Value);
                    for (int j = 0; j < productsListToBuy.Count; j++)
                    {

                        ProductToBuy product = productsListToBuy[j];
                        int currentPromotionQuantity = Convert.ToInt32(currentPromotion[product.ProuductName].Value);
                        product.ProductQuantity = product.ProductQuantity - currentPromotionQuantity;

                        Console.WriteLine("Remaining " + product.ProuductName + "-" + product.ProductQuantity);
                    }
                    i = i - 1;
                }
            }
            return total;
        }

        public int CalculateTotalPriceApplyingUnitPrice(List<ProductToBuy> productsListToBuy)
        {
            int total = 0;
            for (int j = 0; j < productsListToBuy.Count; j++)
            {
                ProductToBuy product = productsListToBuy[j];
                if (product.ProductQuantity > 0)
                {
                    total = total + Convert.ToInt32(this.UnitPrice[product.ProuductName].Value) * product.ProductQuantity;
                }
            }
            return total;
        }

     
    }
}
