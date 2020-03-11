using System;

namespace guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int correctNumber = random.Next(1,10);

            int guess = 0;
            int guesses = 0;

            // for debugging
            System.Console.WriteLine(correctNumber);

            while (guess != correctNumber && guesses < 10) {
                System.Console.Write("Enter a number between 1 and 10: ");
                guess = int.Parse(Console.ReadLine());
                if (guess < correctNumber) System.Console.WriteLine("Higher");
                else System.Console.WriteLine("Lower");
                guesses += 1;
            }
            if (guesses == 10 && guess != correctNumber) {
                System.Console.WriteLine("Better luck next time");
            }
            else {
                System.Console.WriteLine("Nice guessing");
            }
        }
    }
}
