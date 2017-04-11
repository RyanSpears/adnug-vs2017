using System;

namespace VS2017_ADNUG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator time: a s m d, valueOne, valueTwo");

            var userEntry = Console.ReadLine();

            while (userEntry != string.Empty)
            {
                var tokens = userEntry.Split(' ');

                if (tokens.Length != 3)
                    break;

                var theOperator = tokens[0];
                double valueOne;
                double valueTwo;

                try
                {
                    valueOne = double.Parse(tokens[1]);
                    valueTwo = double.Parse(tokens[2]);
                }
                catch (FormatException)
                {
                    break;
                }

                var result = DoCalculation(theOperator, valueOne, valueTwo);

                Console.WriteLine($"The result is {result}");
                Console.WriteLine("Enter a new operation and values");

                userEntry = Console.ReadLine();
            }

            var person = new Person();
        }

        private static double DoCalculation(string theOperator, double valueOne, double valueTwo)
        {
            switch (theOperator)
            {
                case "a":
                    return Calculator.Add(valueOne, valueTwo);
                case "s":
                    return Calculator.Subtract(valueOne, valueTwo);
                case "m":
                    return Calculator.Multiply(valueOne, valueTwo);
                case "d":
                    return Calculator.Divide(valueOne, valueTwo);
                default:
                    return 0;
            }
        }
    }
}
