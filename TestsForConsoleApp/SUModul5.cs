using System;
using SoftwareUdvikling;
namespace TestsForConsoleApp
{
    [TestClass]
    public class SUModul5
    {
        [TestMethod]
        public void notNegative() {
            DiscountCalculator discountCalculator = new DiscountCalculator();
            Assert.ThrowsException<ArgumentException>(() => discountCalculator.CalculateFinalPrice(-1, 0, true));
        }

        [TestMethod]
        public void isMember() {
            DiscountCalculator discountCalculator = new();
            Assert.AreEqual(discountCalculator.CalculateFinalPrice(100, 1, true), 100 * 0.95);
            Assert.AreNotEqual(discountCalculator.CalculateFinalPrice(100, 1, false), 100 * 0.95);
        }

        [TestMethod]
        public void oldCustomer() {
            DiscountCalculator discountCalculator = new();
            Assert.AreEqual(discountCalculator.CalculateFinalPrice(100, 6, false), 100 * 0.90);
            Assert.AreNotEqual(discountCalculator.CalculateFinalPrice(100, 5, false), 100 * 0.90);
        }

        [TestMethod]
        public void bigPrice() {
            DiscountCalculator discountCalculator = new();
            Assert.AreEqual(discountCalculator.CalculateFinalPrice(1001, 1, false), 1001 * 0.95);
            Assert.AreNotEqual(discountCalculator.CalculateFinalPrice(1000, 1, false), 1000 * 0.95);
        }

        [TestMethod]
        public void testMany() {
            DiscountCalculator discountCalculator = new();
            Assert.AreEqual(discountCalculator.CalculateFinalPrice(1001, 6, true), 1001 * 0.8);
            Assert.AreEqual(discountCalculator.CalculateFinalPrice(100, 6, true), 100 * 0.85);
        }
    }
}
