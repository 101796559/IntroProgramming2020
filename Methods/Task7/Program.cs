using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = getNumbers();
            if (numbers != null)
            {
                RaiseToPower(numbers[0], numbers[1]);
            }
            else
            {
                System.Console.WriteLine("Please try again later.");
            }
        }

        static void RaiseToPower(int baseNo, int exponent)
        {
            System.Console.WriteLine($"The number {baseNo} raised to the power {exponent} is {formatCommas(Math.Pow(baseNo, exponent).ToString())}");
        }

        static int[] getNumbers()
        {
            int limit = 2;
            int[] numbers = new int[limit];
            int attempts = 0;
            int counter = 0;

            while (attempts < 3 && counter < limit)
            {
                string another = (counter > 0) ? "the Exponent" : "Base Number";
                System.Console.Write($"Enter {another}: ");
                if (int.TryParse(Console.ReadLine(), out numbers[counter]))
                {
                    counter += 1;
                    attempts = 0;
                }
                else
                {
                    attempts += 1;
                    System.Console.WriteLine("That's not a number!");
                }
            }

            if (attempts < 3) return numbers;
            else return null;
        }

        /*  
        Ignore this stuff, this is just me being anal.
        Also I'm sure there's an easier way to do this
        but I couldn't find it quickly enough. 
        I'll re-use this later too.
        */
        static string formatCommas(string input)
        {
            input = input.Replace("-","");
            string interrum = "";
            char[] backwards = new char[input.Length];
            int counter = 0;
            foreach (char x in input)
            {
                backwards[counter] = x;
                counter += 1;
            }
            Array.Reverse(backwards);

            counter = 0;
            foreach (char x in backwards)
            {
                counter += 1;
                interrum += (counter % 3 == 0 && counter < backwards.Length) ? $"{x}," : $"{x}";
            }

            char[] outputChar = new char[interrum.Length];
            counter = 0;
            foreach (char x in interrum)
            {
                outputChar[counter] += x;
                counter += 1;
            }

            Array.Reverse(outputChar);

            string output = "";
            foreach (char x in outputChar)
            {
                output += $"{x}";
            }

            return output;
        }
    }
}
