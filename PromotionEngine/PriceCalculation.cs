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
            int totalFromPromotion = 0;
            
            return totalFromPromotion;
        }


        public int CalculateTotalPriceApplyingPromotion(List<ProductToBuy> productsListToBuy)
        {
            int total = 0;
           
            return total;
        }

        public int CalculateTotalPriceApplyingUnitPrice(List<ProductToBuy> productsListToBuy)
        {
            int total = 0;

            return total;
        }

     
    }
}
