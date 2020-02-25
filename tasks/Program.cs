using System;

namespace tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int minimumResult = 1;
            int maximumResult = 10;

            Console.WriteLine("Welcome to the number guessing game.");
            Console.WriteLine("Guess a number between " + minimumResult.ToString() + " and " + maximumResult.ToString());

            int guess = Convert.ToInt32(Console.ReadLine());

            while (guess != maximumResult) {
                if (guess < maximumResult)
                {
                    Console.WriteLine("Nope. Higher");
                }
                else if (guess > maximumResult)
                {
                    Console.WriteLine("Nope. Lower");
                }
                Console.WriteLine("Choose another number between " + minimumResult.ToString() + " and " + maximumResult.ToString());
                guess = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Nice guess!");
                
        }
    }
}
