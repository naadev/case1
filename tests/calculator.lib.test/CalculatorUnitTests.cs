using calculator.lib;

namespace calculator.lib.test
{
    public class CalculatorUnitTests
    {
        [Theory]
        [InlineData(3, 5, 8)]
        [InlineData(-3, 5, 2)]
        [InlineData(3, -5, -2)]
        [InlineData(-3, -5, -8)]
        public void TestAdd(int number1,int number2,int expectedResult)
        {
            var result = Calculator.Add(number1, number2);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(3, 5, -2)]
        [InlineData(-3, 5, -8)]
        [InlineData(3, -5, 8)]
        [InlineData(-3, -5, 2)]
        public void TestSubstract(int number1, int number2, int expectedResult)
        {
            var result = Calculator.Subtract(number1, number2);
            Assert.Equal(expectedResult, result);
        }
        [Theory]
        [InlineData(3, 5, 15)]
        [InlineData(-3, 5, -15)]
        [InlineData(3, -5, -15)]
        [InlineData(-3, -5, 15)]
        public void TestMultiply(int number1, int number2, int expectedResult)
        {
            var result = Calculator.Multiply(number1, number2);
            Assert.Equal(expectedResult, result);
        }
        [Theory]
        [InlineData(15, 3, 5)]
        [InlineData(5, 2, 2.5)]
        [InlineData(30, -5, -6)]
        [InlineData(-30, -5, 6)]
        public void TestDivide(int number1, int number2, double expectedResult)
        {
            var result = Calculator.Divide(number1, number2);
            Assert.Equal(expectedResult, result);
        }

    }
}