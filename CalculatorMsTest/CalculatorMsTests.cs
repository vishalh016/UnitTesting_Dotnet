using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;
//using Calculator;
namespace CalculatorMsTest
{
    [TestClass]
    public class CalculatorMsTests
    {
        [TestMethod]
        public void Addition_twoint_getCorrectResult()
        {
            //Arrange 
            Calculator c = new();
            //Act
            int r = c.Add(10, 20);
            //Assert
            Assert.AreEqual(30, r);
        }
    }
}