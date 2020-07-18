using System;
using Shop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShopTest
{
    [TestClass]
    public class ChemicalsTest
    {
        [TestMethod]
        public void Test_ShampooPlusSoap()
        {
            Shampoo shampoo = new Shampoo();
            Soap soap = new Soap();
            Assert.AreEqual(new Chemicals("Shampoo - Soap", 4.65), shampoo + soap);
        }

        [TestMethod]
        public void Test_ShampooPlusToothpaste()
        {
            Shampoo shampoo = new Shampoo();
            Toothpaste toothpaste = new Toothpaste();
            Assert.AreEqual(new Chemicals("Shampoo - Toothpaste", 7), shampoo + toothpaste);
        }

        [TestMethod]
        public void Test_ToothpastePlusSoap()
        {
            Soap soap = new Soap();
            Toothpaste toothpaste = new Toothpaste();
            Assert.AreEqual(new Chemicals("Toothpaste - Soap", 3.15), toothpaste + soap);
        }

        [TestMethod]
        public void Test_SoapToDouble()
        {
            double number = new Soap();
            Assert.AreEqual(0.8, number);
        }

        [TestMethod]
        public void Test_ToothpasteToInt()
        {
            int number = new Toothpaste();
            Assert.AreEqual(550, number);
        }

        [TestMethod]
        public void Test_ComputerToChemicals()
        {
            Computer computer = new Computer();
            Assert.AreEqual(new Chemicals("Computer", 1322.5), (Chemicals)computer);
        }

        [TestMethod]
        public void Test_BreadToChemicals()
        {
            Bread bread = new Bread();
            Assert.AreEqual(new Chemicals("Bread", 0.69), (Chemicals)bread);
        }
    }
}
