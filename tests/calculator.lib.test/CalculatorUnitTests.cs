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

        [Fact]
        public void TestSubstract()
        {
            var result = Calculator.Subtract(2, 2);
            Assert.Equal(0, result);
        }
        [Fact]
        public void TestMultiply()
        {
            var result = Calculator.Multiply(2, 2);
            Assert.Equal(4, result);
        }
        [Fact]
        public void TestDivide()
        {
            var result = Calculator.Divide(2, 2);
            Assert.Equal(1, result);
        }
    }
}