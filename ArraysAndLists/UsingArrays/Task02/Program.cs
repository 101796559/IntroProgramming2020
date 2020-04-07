using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            // A program starts with the values 34, 5, 67, 1, 99, 34, 44, 78, 34, 0. Write a program that adds all numbers together and outputs the total.
            int[] numbers = {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};

            int result = 0;
            foreach(int number in numbers) {
                result += number;
            }
            System.Console.WriteLine(result);
        }
    }
}
