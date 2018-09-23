using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzEngineUnitTest
{
    [TestClass]
    public class BuzzCheckerTests
    {
        [TestMethod]
        public void MultipleOf5ReturnsTrue()
        {
            // Arrange
            IBuzzChecker buzzChecker;
            buzzChecker = new BuzzChecker();

            int testInt1 = 10;
            int testInt2 = 95;

            // Act
            bool testReturn1 = buzzChecker.BuzzNumber(testInt1);
            bool testReturn2 = buzzChecker.BuzzNumber(testInt2);

            // Assert
            Assert.AreEqual(true, testReturn1);
            Assert.AreEqual(true, testReturn2);
        }

        [TestMethod]
        public void NotAMultipleOf5ReturnsFalse()
        {
            // Arrange
            IBuzzChecker buzzChecker;
            buzzChecker = new BuzzChecker();

            int testInt1 = 4;
            int testInt2 = 78;

            // Act
            bool testReturn1 = buzzChecker.BuzzNumber(testInt1);
            bool testReturn2 = buzzChecker.BuzzNumber(testInt2);

            // Assert
            Assert.AreEqual(false, testReturn1);
            Assert.AreEqual(false, testReturn2);
        }
    }
}
