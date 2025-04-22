using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareUdvikling;
namespace TestsForConsoleApp
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void addNumbers() {
            Calculator c = new();
            Assert.AreEqual(c.add(2,2), 4);
            Assert.AreEqual(c.add(2, 3), 5);
        }

        [TestMethod]
        public void subtractNumbers() {
            Calculator c = new();
            Assert.AreEqual(c.subtract(10, 3), 7);
            Assert.AreEqual(c.subtract(3, 10), -7);
        }

        [TestMethod]
        public void divideNumbers() {
            Calculator c = new();

            Assert.AreEqual(c.divide(2, 2), 1);
            Assert.AreEqual(c.divide(6, 2), 3);
            Assert.ThrowsException<DivideByZeroException>(() => c.divide(2, 0));
            
        }
    }
}
