using System;

namespace guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pick a number between minValue and maxValue
            int minValue = 1;
            int maxValue = 10;

            // Correct answer is within the specified range.
            Random random = new Random();
            int correctNumber = random.Next(minValue, maxValue);

            int guess = 0;
            int guesses = 0;
            int maxGuesses = 5;
            string missed = "";

            int[] previousGuesses = new int[maxGuesses];

            // While you're wrong and I still care what you have to say
            while (guess != correctNumber && guesses < maxGuesses) {
                // For neatness
                Console.Clear();
                
                // If you've already entered an incorrect answer, try this. If not, here's what the game's called.
                if (missed != "") {
                    System.Console.WriteLine(missed);
                }
                else {
                    System.Console.WriteLine("Guess the number!");
                }
                
                System.Console.WriteLine("Guesses remaining: {0}", maxGuesses - guesses);
                System.Console.Write("Enter a number between {0} and {1}: ", minValue, maxValue);
                guess = int.Parse(Console.ReadLine());
                
                if (guess < correctNumber) missed = "Higher";
                else if (guess > correctNumber) missed = "Lower";
                
                previousGuesses[guesses] = guess;
                guesses += 1;
            }

            if (guesses == maxGuesses && guess != correctNumber) {
                System.Console.WriteLine("Better luck next time.");
            }
            else {
                System.Console.WriteLine("Nice guessing");
            }

            string message = "Your guesses: ";
            for (int i = 0; i < maxGuesses; i++) {
                message += previousGuesses[i] + " ";
            }
            System.Console.WriteLine(message);
        }
    }
}
