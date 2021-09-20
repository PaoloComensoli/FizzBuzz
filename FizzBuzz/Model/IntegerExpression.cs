using System;

namespace FizzBuzz.Model
{
    public class IntegerExpression
    {
        private readonly string _value;

        public IntegerExpression(string value)
        {
            _value = value;
        }

        public IntegerExpression(int value)
        {
            _value = value.ToString();
        }

        public bool IsPositiveInteger()
        {
            return Int32.TryParse(_value, out int value);
        }

        public bool IsDivisibleBy(int divisor)
        {
            if (!IsPositiveInteger())
            {
                throw new Exception();
            }
            var number = int.Parse(_value);
            return number % divisor == 0;
        }

        public int GetIntValue()
        {
            if (!IsPositiveInteger())
            {
                throw new Exception();
            }

            return int.Parse(_value);
        }

        public string GetStringValue()
        {
            if (!IsPositiveInteger())
            {
                throw new Exception();
            }
            var number = int.Parse(_value);
            string result = "";
            if (IsDivisibleBy(3) )
            {
                result += "Fizz";
            }
            if (IsDivisibleBy(5))
            {
                result += "Buzz";
            }
            if (IsDivisibleBy(7))
            {
                result += "Foo";
            }
            if (result=="")
                return _value;
            return result;
        }
    }
}