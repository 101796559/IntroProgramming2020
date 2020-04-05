using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 2
            int counter = 0;
            int lines = 10;
            int defaultLines = lines;

            while (counter < 3) {
                System.Console.Write($"Enter number of lines to display (default {defaultLines}): ");
                string response = Console.ReadLine();
                if (response != "") {
                    if (!int.TryParse(response, out lines)) {
                        System.Console.WriteLine("Enter an integer.");
                        counter += 1;
                    }
                    else {
                        counter = 10; // breaks loop without needing an additional variable.
                    }
                }
                else {
                    counter = 10;
                }
            }

            counter = 0;
            while (counter < lines) {
                int counter2 = counter;

                while (counter2 < lines) {
                    System.Console.Write("x");
                    counter2 += 1;
                }

                System.Console.WriteLine();
                counter += 1;
            }
        }
    }
}