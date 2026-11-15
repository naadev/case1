using calculator.lib;

namespace calculator.lib.test
{
    public class NumberAttributerTests
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(1, false)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(7, true)]
        [InlineData(8, false)]
        [InlineData(9, false)]
        public void Test_IsPrime(int number, bool isItPrime)
        {
            var isPrime = NumberAttributter.IsPrime(number);
            Assert.True(isItPrime == isPrime);
        }
    }
}