using FizzBuzz.Model;
using System.Collections.Generic;
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

        public static List<object[]> listaTest()
        {
            return new List<object[]>
            {
                new object[] { "2", "1 2" },
                new object[] { "3", "1 2 Fizz" },
                new object[] { "7", "1 2 Fizz 4 Buzz Fizz Foo" },
                new object[] { "21", "1 2 Fizz 4 Buzz Fizz Foo 8 Fizz Buzz 11 Fizz 13 Foo FizzBuzz 16 17 Fizz 19 Buzz FizzFoo" },
            };
        }

        [Theory]
        [MemberData(nameof(listaTest))]

        public void HasStringValue(string input, string expected)
        {
            var number = new IntegerExpression(input);
            string valoreFinale = "";
            for (int i=1; i<=number.GetIntValue(); i++)
            {
                IntegerExpression newInt = new IntegerExpression(i);
                valoreFinale += (newInt.GetStringValue() + " ");
            }

            Assert.Equal(expected, valoreFinale.Trim() );
        }
    }
}
