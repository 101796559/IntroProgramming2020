using System;

namespace zero_to_twenty
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (number <= 20) {
                System.Console.WriteLine(number);
                number += 2;
            }
        }
    }
}
