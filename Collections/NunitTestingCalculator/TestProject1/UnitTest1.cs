

using NUnit.Framework;
using NunitTestingCalculator;

namespace TestProject1
{
    
    public class Tests
    {
        CalculatorOperation test;

        [SetUp]
        public void Setup()
        {
            test = new CalculatorOperation();
            
        }

        [TestCase(5,9)]
        
        public void Test1(int a,int b)
        {

            var p= test.Add(a,b);
            var q= 14;

            Assert.Equals(p,q);

        }
    }
}