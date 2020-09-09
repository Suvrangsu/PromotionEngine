using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            JSONParser parser = new JSONParser();
            dynamic promotionEngineModel = parser.ParseJSON();
            PriceCalculation priceCalculation = new PriceCalculation();
            List<ProductToBuy> NoOfProduct = new List<ProductToBuy>();
            priceCalculation.UnitPrice = promotionEngineModel.UnitPrice;
            priceCalculation.ActivePromotions = promotionEngineModel.ActivePromotions;
            foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(promotionEngineModel.UnitPrice))
            {
                Console.WriteLine("No of Product- " + prop.Name + " you want yo buy.");
                int n;
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Clear();
                    Console.WriteLine("You entered an invalid number");
                    Console.WriteLine("No of Product- " + prop.Name + " you want yo buy.");
                }
                ProductToBuy productToBuy = new ProductToBuy();
                productToBuy.ProuductName = prop.Name;
                productToBuy.ProductQuantity = n;

                NoOfProduct.Add(productToBuy);

            }

            int total = priceCalculation.GetTotalPrice(NoOfProduct);
            Console.WriteLine("================================================================================");
            Console.WriteLine("Total price====" + total);

            Console.ReadLine();
        }
    }
}
