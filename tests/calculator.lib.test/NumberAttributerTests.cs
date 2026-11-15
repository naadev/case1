using calculator.lib;

namespace calculator.lib.test
{
    public class NumberAttributerTests
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(1, false)]
        [InlineData(3, true)]
        public void Test_IsPrime(int number, bool isItPrime)
        {
            var isPrime = NumberAttributter.IsPrime(number);
            Assert.True(isItPrime == isPrime);
        }
    }
}