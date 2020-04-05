using System;

namespace AdvancedExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int limit = 10;
            int defaultLimit = limit;

            while (counter < 3) { // Reused from previous exercises
                System.Console.Write($"Enter number of lines to display (default {defaultLimit}): ");
                string response = Console.ReadLine();
                if (response != "") {
                    if (!int.TryParse(response, out limit)) {
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
            while (counter < limit) {
                int counter3 = limit - counter;
                while (counter3 < limit) {
                    System.Console.Write(" ");
                    counter3 += 1;
                }

                int counter2 = counter;
                while (counter2 < (limit - counter) + (limit - 1)) {
                    System.Console.Write("x");
                    counter2 += 1;
                }

                System.Console.WriteLine();
                counter += 1;
            }
        }
    }
}
