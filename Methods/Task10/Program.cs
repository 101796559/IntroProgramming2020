using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int number = getNumber()[0];
                sumDigits(number);
            }
            catch {
                System.Console.WriteLine("Please try again later.");
            }
        }

        public static void sumDigits(int number)
        {
            string numString = (number < 0) ? (number * -1).ToString() : number.ToString();
            int result = 0;
            foreach(char x in numString)
            {
                result += int.Parse($"{x}");
            }

            System.Console.WriteLine($"The sum of the digits in the number {number} is {result}");
        }
        public static int[] getNumber()
        {
            int attempts = 0;
            int[] number = new int[] {0};
            while (attempts < 3)
            {
                System.Console.Write("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out number[0]))
                {
                    break;
                }  
                else
                {
                    System.Console.WriteLine("Invalid input. \nMust be an integer between -2,147,483,647 and 2,147,483,647.");
                    attempts += 1;
                } 
            }

            if (attempts < 3) return number;
            else return null;
        }
    }
}
