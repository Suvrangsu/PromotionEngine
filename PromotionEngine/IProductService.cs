using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public interface IProductService
    {
        int GetTotalPrice(List<ProductToBuy> productsListToBuy);
        int CalculateTotalPriceApplyingPromotion(List<ProductToBuy> productsListToBuy);
        int CalculateTotalPriceApplyingUnitPrice(List<ProductToBuy> productsListToBuy);

    }
}
