using System;
using Shop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShopTest
{
    [TestClass]
    public class TechnicTest
    {
        [TestMethod]
        public void Test_ComputerPlusPhone()
        {
            Computer computer = new Computer();
            Phone phone = new Phone();
            Assert.AreEqual(new Technic("Computer - Phone", 1040.7), computer + phone);
        }

        [TestMethod]
        public void Test_ComputerPlusTV()
        {
            Computer computer = new Computer();
            TV tv = new TV();
            Assert.AreEqual(new Technic("Computer - Television", 1688.375), computer + tv);
        }

        [TestMethod]
        public void Test_TVPlusPhone()
        {
            TV tv = new TV();
            Phone phone = new Phone();
            Assert.AreEqual(new Technic("Television - Phone", 1406.575), tv + phone);
        }

        [TestMethod]
        public void Test_ComputerToDouble()
        {
            double number = new Computer();
            Assert.AreEqual(1322.5, number);
        }

        [TestMethod]
        public void Test_TVToInt()
        {
            int number = new TV();
            Assert.AreEqual(205425, number);
        }

        [TestMethod]
        public void Test_ChocolateToTechnic()
        {
            Chocolate chocolate = new Chocolate();
            Assert.AreEqual(new Technic("Chocolate", 2.25), (Technic)chocolate);
        }

        [TestMethod]
        public void Test_SoapToTechnic()
        {
            Soap soap = new Soap();
            Assert.AreEqual(new Technic("Soap", 0.8), (Technic)soap);
        }
    }
}
