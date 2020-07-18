using System;
using Shop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShopTest
{
    [TestClass]
    public class FoodSupplyTest
    {
        [TestMethod]
        public void Test_BreadPlusChocolate()
        {
            Bread bread = new Bread();
            Chocolate chocolate = new Chocolate();
            Assert.AreEqual(new FoodSupply("Bread - Chocolate", 1.47), bread + chocolate);
        }

        [TestMethod]
        public void Test_BreadPlusMilk()
        {
            Bread bread = new Bread();
            Milk milk = new Milk();
            Assert.AreEqual(new FoodSupply("Bread - Milk", 1.17), bread + milk);
        }

        [TestMethod]
        public void Test_MilkPlusChocolate()
        {
            Milk milk = new Milk();
            Chocolate chocolate = new Chocolate();
            Assert.AreEqual(new FoodSupply("Milk - Chocolate", 1.95), milk + chocolate);
        }

        [TestMethod]
        public void Test_MilkToDouble()
        {
            double number = new Milk();
            Assert.AreEqual(1.65, number);
        }

        [TestMethod]
        public void Test_ChocolateToInt()
        {
            int number = new Chocolate();
            Assert.AreEqual(225, number);
        }

        [TestMethod]
        public void Test_TVToFoodSupply()
        {
            TV tv = new TV();
            Assert.AreEqual(new FoodSupply("Television", 2054.25), (FoodSupply)tv);
        }

        [TestMethod]
        public void Test_ShampooToFoodSupply()
        {
            Shampoo shampoo = new Shampoo();
            Assert.AreEqual(new FoodSupply("Shampoo", 8.5), (FoodSupply)shampoo);
        }
    }
}
