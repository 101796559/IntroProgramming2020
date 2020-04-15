using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = getNumbers(5);
            if (numbers != null) Add(numbers);
            else System.Console.WriteLine("Please try again later.");
        }

        static int[] getNumbers(int length)
        {
            int[] numbers = new int[length];
            bool valid;
            int counter = 0;
            int attempts = 0;
            while (counter < numbers.Length && attempts < 3)
            {
                System.Console.Write($"Enter element {counter + 1}: ");
                valid = int.TryParse(Console.ReadLine(), out numbers[counter]);
                if (valid)
                {
                    attempts = 0;
                    counter += 1;
                }
                else
                {
                    System.Console.WriteLine("That's not a number");
                    attempts += 1;
                }
            }

            if (attempts < 3) return numbers;
            else return null;
        }
    
        public static void Add(params int[] numbers)
        {
            int result = 0;
            foreach (int x in numbers)
            {
                result += x;
            }
            System.Console.WriteLine($"The sum of the elements in the array is: {result}.");
        }
    }
}
