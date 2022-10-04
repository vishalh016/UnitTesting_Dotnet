using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using NUnit.Framework;

namespace CalculatorNunitTest
{
    public class CustomerNunitTests
    {
        Customer c;
        [SetUp]
        public void Setup()
        {
            c = new Customer();
        }

        [Test]
        public void GetNameCheck()
        {
            string f = c.GetName("ABC","XYZ");
            Assert.That(f, Is.EqualTo("hi, ABC XYZ"));

        }
    }
}
