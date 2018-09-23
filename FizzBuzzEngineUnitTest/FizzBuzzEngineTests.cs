using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzzEngineUnitTest
{
    [TestClass]
    public class FizzBuzzEngineTests
    {
        [TestMethod]
        public void MultipleOf3Returns_Fizz()
        {
            FizzBuzzEngine.FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine.FizzBuzzEngine();

            // Arrange
            int testInt1 = 9;
            int testInt2 = 63;
            var expected = "Fizz";

            // Act
            var testReturn1 = fizzBuzzEngine.ConvertToFizzBuzz(testInt1);
            var testReturn2 = fizzBuzzEngine.ConvertToFizzBuzz(testInt2);


            // Assert
            Assert.AreEqual(expected, testReturn1);
            Assert.AreEqual(expected, testReturn2);
        }

        [TestMethod]
        public void MultipleOf5Returns_Buzz()
        {
            FizzBuzzEngine.FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine.FizzBuzzEngine();

            // Arrange
            int testInt1 = 10;
            int testInt2 = 70;
            var expected = "Buzz";

            // Act
            var testReturn1 = fizzBuzzEngine.ConvertToFizzBuzz(testInt1);
            var testReturn2 = fizzBuzzEngine.ConvertToFizzBuzz(testInt2);


            // Assert
            Assert.AreEqual(expected, testReturn1);
            Assert.AreEqual(expected, testReturn2);
        }

        [TestMethod]
        public void MultipleOf3And5Returns_FizzBuzz()
        {
            FizzBuzzEngine.FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine.FizzBuzzEngine();

            // Arrange
            int testInt1 = 15;
            int testInt2 = 45;
            var expected = "FizzBuzz";

            // Act
            var testReturn1 = fizzBuzzEngine.ConvertToFizzBuzz(testInt1);
            var testReturn2 = fizzBuzzEngine.ConvertToFizzBuzz(testInt2);


            // Assert
            Assert.AreEqual(expected, testReturn1);
            Assert.AreEqual(expected, testReturn2);
        }

        [TestMethod]
        public void NotMultipleOf3Or5Returns_TheInput()
        {
            FizzBuzzEngine.FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine.FizzBuzzEngine();

            // Arrange
            int testInt1 = 14;
            int testInt2 = 88;
            var expected1 = testInt1.ToString();
            var expected2 = testInt2.ToString();

            // Act
            var testReturn1 = fizzBuzzEngine.ConvertToFizzBuzz(testInt1);
            var testReturn2 = fizzBuzzEngine.ConvertToFizzBuzz(testInt2);

            // Assert
            Assert.AreEqual(expected1, testReturn1);
            Assert.AreEqual(expected2, testReturn2);
        }
    }
}
