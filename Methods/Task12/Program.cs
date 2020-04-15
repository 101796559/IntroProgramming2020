using System;
using System.Numerics;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = getNumber()[0];
                fibonacci(number);
            }
            catch
            {
                System.Console.WriteLine("Please try again later.");
            }
        }

        public static void fibonacci(int number)
        {
            BigInteger result = getFibonacci(number);
            System.Console.WriteLine($"The Fibonacci of {number}th term is {formatCommas(result.ToString())}");
        }

        public static BigInteger getFibonacci(int number)
        {
            if (number < 2) return number;
            else return getFibonacci(number-1) + getFibonacci(number -2);   
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
                    if (number[0] >= 0) 
                    {
                        return number;
                    }
                    else 
                    {
                        System.Console.WriteLine("Please enter a positive integer.");
                        attempts += 1;

                    }
                }
                else
                {
                    System.Console.WriteLine("Invalid input. \nMust be an integer between -2,147,483,647 and 2,147,483,647.");
                    attempts += 1;
                }
            }

            return null;
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