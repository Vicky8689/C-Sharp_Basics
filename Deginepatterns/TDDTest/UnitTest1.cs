using NUnit.Framework;
using TDD;
namespace TDDTest
{
    public class Tests
    {
        CalculatorOperation test;
        [SetUp]
        public void Setup()
        {
            test = new CalculatorOperation();
        }

        [Test]
        [TestCase(5, 9)]
        public void Test1(int a, int b)
        {

            var p = test.Add(a, b);
            var q = 14;

            Assert.Equals(test.Add(a, b),14);
        }
    }
}