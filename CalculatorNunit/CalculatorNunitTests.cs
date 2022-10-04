using Calculator;
using NUnit.Framework;

namespace CalculatorNunit
{
    public class Tests
    {
        Calculator c;
        [SetUp]
        public void Setup()
        {
            c = new Calculator();
        }

        [Test]

        //check if additon is true?

        //public void Addition_twoInt_getResult()
        //{
        //    bool r = c.IsOdd(12);
        //    //Assert.AreEqual(30, r);
        //    Assert.That(r, Is.EqualTo(true));
        //}



        //check if number is odd?(testcase invalid if fails)


        //[TestCase(11)]
        //[TestCase(18)]
        //public void IsOddChecker_returnTrue(int a) { 
        //    bool r=c.IsOdd(a);
        //    Assert.AreEqual(true, r); 
        //}



        //Proper Testing: 
        //[TestCase(11, ExpectedResult =true)]
        //[TestCase(12, ExpectedResult =false)]
        //public bool IsOddChecker_returnTrueIfOdd(int a)
        //{
        //    return c.IsOdd(a);

        //}

        [TestCase(5.2,4.6)]
        [TestCase(7.3,2.7)]
        [TestCase(4.1,3.9)]
        public void Addition_twoDouble_getResult(double a,double b)
        {
            double d=c.AddD(a,b);
            //Assert.AreEqual(30, r);
            Assert.AreEqual(9,d,1);//last parameter is buffer,if value is +-1 then it'll pass
        }

    }
}