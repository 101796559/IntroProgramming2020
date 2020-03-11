using System;

namespace ten_guesses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set a secret number to 653.  
            // Then program will then loop, 
            // where each loop will ask the user to enter what they think a secret integer is. 
            //If they get it right, print "Correct", 
            // otherwise print "Wrong, counter value is ".  
            // Give the user 10 chances to guess.   
            // Hint: You will need an if statement inside the loop.  
            //Bonus: Make the secret number randomly generate between 1 and 1000 each time the program is run.  
            
            // For bonus
            Random random = new Random();
            int secretNumber = random.Next(1,1000);

            // int secretNumber = 653;
            int userGuess = 0;
            int guesses = 0;
            int maxGuesses = 10;
            int guessesRemaining;

            while (secretNumber != userGuess && guesses < maxGuesses) {
                System.Console.WriteLine("Guess the Secret Number!");
                bool validInput = int.TryParse(Console.ReadLine(), out userGuess);

                guesses += 1;

                if (userGuess == secretNumber) {
                    System.Console.WriteLine("Got it!");
                }
                else {
                    System.Console.WriteLine("Not quite!");
                    guessesRemaining = maxGuesses - guesses;
                    if (guessesRemaining == 0) {
                        System.Console.WriteLine("All out of guesses!");
                    }
                    else {
                        System.Console.WriteLine("You have {0} guesses remaining!", guessesRemaining);
                    }
                }
            }
            
            if (guesses == 10 && userGuess != secretNumber) {
                System.Console.WriteLine("Better luck next time!");
            }
        }
    }
}
