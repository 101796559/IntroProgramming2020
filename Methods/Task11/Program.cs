using System;
using System.Numerics;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = getNumber()[0];
                factorial(number);
            }
            catch
            {
                System.Console.WriteLine("Please try again later.");
            }
        }

        public static void factorial(int number)
        {
            string isNegative = (number < 0) ? "-" : "";
            BigInteger result = multiply(number);
            System.Console.WriteLine($"The factorial of {number}! is {isNegative}{formatCommas(result.ToString())}");
        }
        public static BigInteger multiply(int number)
        {
            if (number >= 1) return number * multiply(number - 1);
            else if (number <= -1) return number * multiply(number + 1);
            else return 1;
        }
        public static int[] getNumber()
        {
            int attempts = 0;
            int[] number = new int[] { 0 };
            while (attempts < 3)
            {
                System.Console.Write("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out number[0]))
                {
                    break;
                }
                else
                {
                    System.Console.WriteLine("Invalid input. \nMust be an integer between -2,147,483,647 and 2,147,483,647.");
                    attempts += 1;
                }
            }

            if (attempts < 3) return number;
            else return null;
        }

        static string formatCommas(string input)
        {
            input = input.Replace("-", "");
            string interrum = "";
            char[] backwards = new char[input.Length];
            int counter = 0;
            foreach (char x in input)
            {
                backwards[counter] = x;
                counter += 1;
            }
            Array.Reverse(backwards);

            counter = 0;
            foreach (char x in backwards)
            {
                counter += 1;
                interrum += (counter % 3 == 0 && counter < backwards.Length) ? $"{x}," : $"{x}";
            }

            char[] outputChar = new char[interrum.Length];
            counter = 0;
            foreach (char x in interrum)
            {
                outputChar[counter] += x;
                counter += 1;
            }

            Array.Reverse(outputChar);

            string output = "";
            foreach (char x in outputChar)
            {
                output += $"{x}";
            }

            return output;
        }
    }
}
