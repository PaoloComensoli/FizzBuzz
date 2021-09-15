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
            if (IsDivisibleBy(3) && IsDivisibleBy(5))
            {
                return "FizzBuzz";
            }else if (IsDivisibleBy(3))
            {
                return "Fizz";
            }
            else if (IsDivisibleBy(5))
            {
                return "Buzz";
            }
            else
            {
                return _value;
            }
        }
    }
}