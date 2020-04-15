using System;

namespace count_to_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int maxNumber;

            System.Console.Write("Enter a number: ");
            maxNumber = int.Parse(Console.ReadLine());

            while (counter <= maxNumber) {
                System.Console.WriteLine(counter);
                counter += 1;
                System.Threading.Thread.Sleep(25);
            }
        }
    }
}
