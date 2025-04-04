using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdSemesterIT.B2FunWithLinkedLists;

namespace TestsForConsoleApp
{
    [TestClass]
    public class ParkingTest
    {
        [TestMethod]
        public void testParking() {
            Assert.AreEqual(120, Parking.payment(60));
        }
    }
}
