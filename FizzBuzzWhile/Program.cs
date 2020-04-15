using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int maxNumber = 100;

            while (number <= maxNumber) {
                if (number % 3 == 0 && number % 5 == 0) {
                    System.Console.WriteLine("FizzBuzz");
                }
                else if (number % 3 == 0) {
                    System.Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0) {
                    System.Console.WriteLine("Buzz");
                }
                else {
                    System.Console.WriteLine(number);
                }
                number += 1;
            }
        }
    }
}
