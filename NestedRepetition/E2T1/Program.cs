using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            int counter = 0;
            while (counter < 5) {
                int counter2 = counter;

                while (counter2 < 5) {
                    System.Console.Write("x");
                    counter2 += 1;
                }

                System.Console.WriteLine();
                counter += 1;
            }
        }
    }
}