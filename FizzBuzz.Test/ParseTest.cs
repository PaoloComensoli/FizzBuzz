using FizzBuzz.Model;
using Xunit;

namespace FizzBuzz.Test
{
    public class ParseTest
    {
        [Theory]
        [InlineData("5", true)]
        [InlineData("10,5", false)]
        [InlineData("pippo", false)]
        public void CanParseAPositiveInt(string number, bool expected)
        {
            var input = new IntegerExpression(number);
            Assert.Equal(expected, input.IsPositiveInteger());
        }

        [Theory]
        [InlineData("5", 5, true)]
        [InlineData("10", 3, false)]
        [InlineData("9", 3, true)]
        [InlineData("15", 5, true)]
        public void IsDivisibleByANumber(string input, int divisor, bool expected)
        {
            var number = new IntegerExpression(input);
            Assert.Equal(expected, number.IsDivisibleBy(divisor));
        }

        [Theory]
        [InlineData("5", "Buzz")]
        [InlineData("10","Buzz")]
        [InlineData("7", "7")]
        [InlineData("15", "FizzBuzz")]
        public void HasStringValue(string input, string expected)
        {
            var number = new IntegerExpression(input);
            Assert.Equal(expected, number.GetStringValue());
        }
    }
}
