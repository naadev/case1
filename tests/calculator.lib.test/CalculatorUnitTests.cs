using calculator.lib;

namespace calculator.lib.test
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAdd()
        {
            var result = Calculator.Add(2, 2);
            Assert.Equal(4, result);
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