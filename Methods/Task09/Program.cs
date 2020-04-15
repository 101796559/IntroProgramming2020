using System;

namespace Task09
{
    class Program
    {
        public static void Main()
        {
            try {
                int number = getNumber()[0];
                isPrime(number);
            }
            catch {
                System.Console.WriteLine("Please try again later.");
            }
        }

        public static void isPrime(int number)
        {
            int results = 0;
            for (int i = 1; i <= number; i++) {
                if (number % i == 0) {
                results++;
                }
            }
            if (results > 2) Console.WriteLine($"{number} is not a prime number");
            else Console.WriteLine($"{number} is a prime number");
        }

        public static int[] getNumber()
        {
            int attempts = 0;
            int[] number = new int[1];
            while (attempts < 3)
            {
                System.Console.Write("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out number[0]))
                {
                    break;
                }  
                else
                {
                    System.Console.WriteLine("Invalid input. Must be an integer between -2,147,483,647 and 2,147,483,647.");
                    attempts += 1;
                } 
            }

            if (attempts < 3) return number;
            else return null;
        }
    }
}
