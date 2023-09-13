using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace Test_MOQ_ConsoleApp
{
    [TestFixture]
    public class MOQ_Test_Calculator
    {
        private IUSD_INR_RateFeed GetExchangeRateFeed()
        {
            Mock<IUSD_INR_RateFeed> mockObject = new Mock<IUSD_INR_RateFeed> ();

            mockObject.Setup(m => m.GetExchangeRate()).Returns(82);

            return mockObject.Object;
        }

        [Test]
        public void TestCase_ConvertUSDtoINR()
        {
            IUSD_INR_RateFeed testFeed = GetExchangeRateFeed();

            ICalculator calculator = new Calculator(testFeed);

            int actualResult = calculator.ConvertUSDtoINR(5);

            int expectedResult = 410;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
