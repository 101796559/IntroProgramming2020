using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = getNumbers(2);
            if (numbers != null) {
                numbers = Swap(numbers[0], numbers[1]);
            }
        }

        public static int[] Swap(int num1, int num2) {
            System.Console.WriteLine($"Before, the first number was {num1} and the second was {num2}.");
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            System.Console.WriteLine($"Now, the first number is {num1} and the second is {num2}.");
            int[] results = new int[] {num1, num2};
            return results;
        }

        public static int[] getNumbers(int limit) {
            int[] numbers = new int[limit];
            int attempts = 0, counter = 0;

            while (attempts < 3 && counter < limit)
            {
                string another = (counter > 0) ? "another" : "a";
                System.Console.Write($"Enter {another} number: ");
                if (int.TryParse(Console.ReadLine(), out numbers[counter]))
                {
                    attempts = 0;
                    counter += 1;
                }
                else
                {
                    attempts += 1;
                }
            }
        
            if (attempts < 3) return numbers;
            else return null;
        }
    }
}
