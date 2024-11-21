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
        [InlineData(10, false)]
        [InlineData(12, false)]
        [InlineData(13, true)]
        [InlineData(15, false)]
        [InlineData(17, true)]
        [InlineData(18, false)]
        [InlineData(20, false)]
        [InlineData(22, false)]
        [InlineData(23, true)]
        [InlineData(24, false)]
        [InlineData(25, false)]
        [InlineData(26, false)]
        [InlineData(27, false)]
        [InlineData(29, true)]
        [InlineData(30, false)]
        [InlineData(31, true)]
        [InlineData(32, false)]
        [InlineData(33, false)]
        [InlineData(2197,false)] // 13^3
        [InlineData(1009,true)]
        public void Test_IsPrime(int number, bool isItPrime)
        {
            var isPrime = NumberAttributter.IsPrime(number);
            Assert.True(isItPrime == isPrime);
        }

        [Fact]
        public void test_a_large_number()
        {
            Assert.True(NumberAttributter.IsPrime(int.MaxValue));
        }
    }
}