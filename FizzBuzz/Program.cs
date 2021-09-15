using System;
using FizzBuzz.Model;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci un numero maggiore di 0: ");
            var input = new IntegerExpression(Console.ReadLine());
            if (input.IsPositiveInteger())
            {
                for (int i = 1; i <= input.GetIntValue(); ++i)
                {
                    var tmp = new IntegerExpression(i);
                    Console.WriteLine(tmp.GetStringValue());
                }
            }
            else
            {
                Console.WriteLine("Non hai inserito un numero.");
            }

        }
    }
}
