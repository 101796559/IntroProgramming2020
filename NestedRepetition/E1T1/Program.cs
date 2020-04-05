using System;

namespace NestedRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            int counter = 0;
            while (counter < 10) {
                int counter2 = 0;

                while(counter2 < 10) {
                    System.Console.Write($"{userName} ");
                    counter2 += 1;
                }

                System.Console.WriteLine();
                counter += 1;
            }
        }
    }
}