using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorWithTests.Tests {
    [TestClass]
    public class CalculatorTests {

        //Test method is an attribute
        [TestMethod]
        public void TestAddNumbers() {

            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Add(13, 17);
            //Assert
            Assert.AreEqual(30, result);
        }


        [TestMethod]
        public void TestSubtractNumbers() {

            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Subtract(23, 3);
            //Assert
            Assert.AreEqual(20, result);
        }
        [TestMethod]
        public void TestMultiplyNumbers() {

            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Multiply(23, 3);
            //Assert
            Assert.AreEqual(69, result);
        }
        [TestMethod]
        public void TestDivideNumbers() {

            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Divide(20, 5);
            //Assert
            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void TestDivideByZero() {

            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Divide(20, 0);
            //Assert
            Assert.AreEqual(double.PositiveInfinity, result);
        }
        [TestMethod]
        public void TestDivideFrac() {

            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Divide(3, 5);
            //Assert
            Assert.AreEqual(0.6, result);
        }
        [TestMethod]
        public void TestDivideNegative() {

            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Divide(-20, 5);
            //Assert
            Assert.AreEqual(-4, result);
        }
        [TestMethod]
        public void TestExponential() {

            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Exp(2, 10);
            //Assert
            Assert.AreEqual(1024, result);
        }
        [TestMethod]
        public void TestExponentialNegativeBaseEvenExp() {

            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Exp(-2, 10);
            //Assert
            Assert.AreEqual(1024, result);
        }
        [TestMethod]
        public void TestExponentialNegativeBaseOddExp() {

            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Exp(-2, 9);
            //Assert
            Assert.AreEqual(-512, result);
        }
        [TestMethod]
        public void TestExponentialNegativeBaseNegativeEvenExp() {

            //Arrange
            var calculator = new Calculator();
            //Act
            var result = calculator.Exp(-2, -2);
            //Assert
            Assert.AreEqual(.25, result);
        }
    }
}
