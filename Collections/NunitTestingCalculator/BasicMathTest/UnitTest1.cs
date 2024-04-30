using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NunitTestingCalculator;
namespace BasicMathTest
{
    [TestClass]  //Requried for classes
    public class UnitTest1
    {
        [TestMethod]   //Requride for Methods
        public void TestAddMethod()
        {
            //Create object of class in witch method are writen
            CalculatorOperation test = new CalculatorOperation();
            int res = test.Add(10, 10);
            Assert.AreEqual(20, res);

        }

        [TestMethod]
        public void TestSubtractMethod()
        {
            CalculatorOperation test = new CalculatorOperation();
            int res = test.Sub(10, 10);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestMultiplyMethod()
        {
            CalculatorOperation test = new CalculatorOperation();
            int res = test.Multiply(10, 10);
            Assert.AreEqual(100, res);
        }
        [TestMethod]
        public void TestDevideMethod()
        {
            CalculatorOperation test = new CalculatorOperation();
            int res =test.Divide(10, 10);
            Assert.AreEqual(1, res);
        }
    }
}
