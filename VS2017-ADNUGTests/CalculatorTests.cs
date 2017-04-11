using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VS2017_ADNUG.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Assert.IsTrue(5.0 == Calculator.Add(1,4));
        }

        [TestMethod()]
        public void SubtractTest()
        {

            Assert.IsTrue(-4 == Calculator.Subtract(1, 5));
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.IsTrue(4.0 == Calculator.Multiply(1, 4));
        }

        [TestMethod()]
        public void DivideTest()
        {
            Assert.IsTrue(0.25 == Calculator.Divide(1, 4));
        }
    }
}