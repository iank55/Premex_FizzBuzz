using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzEngineUnitTest
{
    [TestClass]
    public class FizzCheckerTests
    {
        [TestMethod]
        public void MultipleOf3ReturnsTrue()
        {
            // Arrange
            IFizzChecker fizzChecker;
            fizzChecker = new FizzChecker();

            int testInt1 = 9;
            int testInt2 = 63;

            // Act
            bool testReturn1 = fizzChecker.FizzNumber(testInt1);
            bool testReturn2 = fizzChecker.FizzNumber(testInt2);

            // Assert
            Assert.AreEqual(true, testReturn1);
            Assert.AreEqual(true, testReturn2);
        }

        [TestMethod]
        public void NotAMultipleOf3ReturnsFalse()
        {
            // Arrange
            IFizzChecker fizzChecker;
            fizzChecker = new FizzChecker();

            int testInt1 = 2;
            int testInt2 = 98;

            // Act
            bool testReturn1 = fizzChecker.FizzNumber(testInt1);
            bool testReturn2 = fizzChecker.FizzNumber(testInt2);

            // Assert
            Assert.AreEqual(false, testReturn1);
            Assert.AreEqual(false, testReturn2);
        }
    }
}
