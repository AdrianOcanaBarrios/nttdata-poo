using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Tests
{
    
    [TestClass()]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();
        [TestMethod()]
        public void AddTest()
        {
            //
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Add(2,2)==4);
            Assert.IsFalse(calculator.Add(2, 2) == 3);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Substract(2, 2) == 0);

        }

        [TestMethod()]
        public void MultplyTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Multply(3, 2) == 6);
        }

        [TestMethod()]
        public void DivideTest()
        {
            var calculator = new Calculator();
            Assert.IsTrue(calculator.Divide(6, 3) == 2);
        }
    }
}