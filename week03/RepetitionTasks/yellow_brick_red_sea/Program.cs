using System;

namespace yellow_brick_red_sea
{
    class Program
    {
        static void Main(string[] args)
        { 
            string userAnswer = "";
            string correctAnswer = "gets wet";
            int guesses = 0;

            while (userAnswer != correctAnswer && guesses < 5) {
                System.Console.WriteLine("What happens when you throw a yellow brick into the red sea?");
                System.Console.Write("It....");
                userAnswer = Convert.ToString(Console.ReadLine());
                if (userAnswer != correctAnswer) {
                    System.Console.WriteLine("Wrong answer!");
                    guesses += 1;
                }
            }

            if (userAnswer == correctAnswer) {
                System.Console.WriteLine("Got it! It gets wet!");
            }
            else {
                System.Console.WriteLine("Too many tries.\n{0}!", correctAnswer);
            }
        }
    }
}
