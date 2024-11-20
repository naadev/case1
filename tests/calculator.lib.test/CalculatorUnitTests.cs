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
    }
}