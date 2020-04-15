using System;
using System.Numerics;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = getNumber();
            if (n >= 0) Fibonnacci(n);
            else if (n == -123456789) System.Console.WriteLine("Please try again later.");
            // -n should exist, I just don't understand how to do it.
            else System.Console.WriteLine($"The Fibonacci series of {n} cannot be calulated at this time.");
        }

        static void Fibonnacci(double n)
        {
            BigInteger n1 = 0, n2 = 1, n3;
            if (n > 1) {
                string message = "";

                message += $"{n1} {n2} ";

                for (double i = 2; i <= n; i++)
                {
                    n3 = n1 + n2;
                    message += $"{n3} ";
                    n1 = n2;
                    n2 = n3;
                }

                System.Console.WriteLine($"The Fibonnaci series of {n} is:");
                System.Console.WriteLine(message);
            }
            else System.Console.WriteLine("The Fibonacci series of 0 is: \n0");
        }

        static int getNumber()
        {
            int attempts = 0, number = 0;
            while (attempts < 3) {
                System.Console.Write("Enter number of Fibonacci sequence: ");
                if (int.TryParse(Console.ReadLine(), out number)) {
                    attempts = 0;
                    break;
                }
                else {
                    attempts += 1;
                    System.Console.WriteLine("That's not a number");
                }
            }

            if (attempts < 3) return number;
            else return -123456789;
        }
    }
}
