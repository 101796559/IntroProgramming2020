using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                int[] numbers = getNumbers();
                int num1 = numbers[0], num2 = numbers[1];
                Add(num1, num2);
            }            
            catch {
                System.Console.WriteLine("Please try again later.");
            }
        }
        public static void Add(int num1, int num2) 
        {
            System.Console.WriteLine($"The sum of the two numbers is: {num1 + num2}.");
        }

        public static int[] getNumbers() 
        {
            int[] numbers = new int[2];
            int attempts = 0, counter = 0;
            
            while (attempts < 3 && counter < 2) {
                System.Console.Write("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out numbers[counter])) {
                    attempts = 0;
                    counter += 1;
                }
                else {
                    System.Console.WriteLine("That's not a number!");
                    attempts += 1;
                }
            }

            if (attempts < 3) return numbers;
            else return null;
        }
    }
}
