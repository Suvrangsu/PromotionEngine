using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expected = 100; 
            List<ProductToBuy> listProduct = new List<ProductToBuy>();
            PriceCalculation priceCalculation = new PriceCalculation();
            ProductToBuy productToBuy = new ProductToBuy();
            JSONParser parser = new JSONParser();
            dynamic promotionEngineModel = parser.ParseJSON();
            priceCalculation.UnitPrice = promotionEngineModel.UnitPrice;
            priceCalculation.ActivePromotions = promotionEngineModel.ActivePromotions;


            productToBuy.ProuductName = "A";
            productToBuy.ProductQuantity = 1;
            listProduct.Add(productToBuy);

            productToBuy = new ProductToBuy();
            productToBuy.ProuductName = "B";
            productToBuy.ProductQuantity = 1;
            listProduct.Add(productToBuy);

            productToBuy = new ProductToBuy();
            productToBuy.ProuductName = "C";
            productToBuy.ProductQuantity = 1;
            listProduct.Add(productToBuy);

            productToBuy = new ProductToBuy();
            productToBuy.ProuductName = "D";
            productToBuy.ProductQuantity = 0;
            listProduct.Add(productToBuy);

            int actual = priceCalculation.GetTotalPrice(listProduct);
            Assert.AreEqual(expected, actual, "Test Method 1 failed");
        }

        [TestMethod]
        public void TestMethod2()
        {
            int expected = 370;
            List<ProductToBuy> listProduct = new List<ProductToBuy>();
            PriceCalculation priceCalculation = new PriceCalculation();
            ProductToBuy productToBuy = new ProductToBuy();
            JSONParser parser = new JSONParser();
            dynamic promotionEngineModel = parser.ParseJSON();
            priceCalculation.UnitPrice = promotionEngineModel.UnitPrice;
            priceCalculation.ActivePromotions = promotionEngineModel.ActivePromotions;


            productToBuy.ProuductName = "A";
            productToBuy.ProductQuantity = 5;
            listProduct.Add(productToBuy);

            productToBuy = new ProductToBuy();
            productToBuy.ProuductName = "B";
            productToBuy.ProductQuantity = 5;
            listProduct.Add(productToBuy);

            productToBuy = new ProductToBuy();
            productToBuy.ProuductName = "C";
            productToBuy.ProductQuantity = 1;
            listProduct.Add(productToBuy);

            productToBuy = new ProductToBuy();
            productToBuy.ProuductName = "D";
            productToBuy.ProductQuantity = 0;
            listProduct.Add(productToBuy);

            int actual = priceCalculation.GetTotalPrice(listProduct);
            Assert.AreEqual(expected, actual, "Test Method 2 failed");
        }

        [TestMethod]
        public void TestMethod3()
        {
            int expected = 280;
            List<ProductToBuy> listProduct = new List<ProductToBuy>();
            PriceCalculation priceCalculation = new PriceCalculation();
            ProductToBuy productToBuy = new ProductToBuy();
            JSONParser parser = new JSONParser();
            dynamic promotionEngineModel = parser.ParseJSON();
            priceCalculation.UnitPrice = promotionEngineModel.UnitPrice;
            priceCalculation.ActivePromotions = promotionEngineModel.ActivePromotions;


            productToBuy.ProuductName = "A";
            productToBuy.ProductQuantity = 3;
            listProduct.Add(productToBuy);

            productToBuy = new ProductToBuy();
            productToBuy.ProuductName = "B";
            productToBuy.ProductQuantity = 5;
            listProduct.Add(productToBuy);

            productToBuy = new ProductToBuy();
            productToBuy.ProuductName = "C";
            productToBuy.ProductQuantity = 1;
            listProduct.Add(productToBuy);

            productToBuy = new ProductToBuy();
            productToBuy.ProuductName = "D";
            productToBuy.ProductQuantity = 1;
            listProduct.Add(productToBuy);

            int actual = priceCalculation.GetTotalPrice(listProduct);
            Assert.AreEqual(expected, actual, "Test Method 3 failed");
        }
    }
}
