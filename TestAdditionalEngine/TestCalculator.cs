using NUnit.Framework;
using Additional.Engine;

namespace Additional.Engine.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(-1, -2, -3)]
        [TestCase(0, 0, 0)]
        [TestCase(1.1, 2.2, 3.3)]
        public void Add_AddsTwoNumbers_ReturnsExpectedResult(double a, double b, double expectedResult)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            double result = calculator.Add(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult).Within(1e-10), "Calculator did not add two numbers correctly.");
        }
    }
}
