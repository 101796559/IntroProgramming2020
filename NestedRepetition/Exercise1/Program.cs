using System;

namespace NestedRepetition
{
    class Program
    {
        static void Main(string[] args)
        {   
            // A program receives a user's name and prints it for the amount of times that the user specifies.
            System.Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            int repeats = 10; 
            int defaultRepeats = repeats;
            int attempts = 0;
            int maxAttempts = 3;
            while (attempts < maxAttempts) {
                System.Console.Write($"Enter number of times to repeat (default {defaultRepeats}): ");
                string response = Console.ReadLine();
                if (response != "") {
                    if (!int.TryParse(response, out repeats)) {
                        System.Console.WriteLine("Value entered must be an integer.");
                        attempts += 1;
                    }
                    else {
                        attempts = 10;
                    }
                }
                else {
                    attempts = 10;
                }
            }

            int counter = 0;
            while (counter < repeats) {
                System.Console.Write($"{userName} ");
                counter += 1;
            }

            if (attempts > maxAttempts - 1) {
                System.Console.WriteLine("Too many attempts.");
            }
            else {
                System.Console.WriteLine();
            }
        }
    }
}
