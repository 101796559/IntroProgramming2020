using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizz = 3;
            int buzz = 5;

            for (int i = 1; i <= 100; i++) {
                if (i % fizz == 0 && i % buzz == 0) {
                    System.Console.WriteLine("FizzBuzz");
                }
                else if (i % fizz == 0) {
                    System.Console.WriteLine("Fizz");
                }
                else if (i % buzz == 0) {
                    System.Console.WriteLine("Buzz");
                }
                else {
                    System.Console.WriteLine(i);
                }
            }
        }
    }
}
