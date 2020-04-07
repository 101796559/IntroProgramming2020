using System;
using System.Collections.Generic;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads in 5 numbers. It then asks the user for another number and outputs whether the number has already been entered.
            int selection, counter, attempts;
            selection = counter = attempts = 0;
            bool response;
            int limit = 5;
            
            List<int> firstList = new List<int>();
            
            System.Console.WriteLine($"Enter {limit} number(s)");
            while (counter < limit && attempts < 3) {
                System.Console.Write($"{counter + 1}: ");
                response = int.TryParse(Console.ReadLine(), out selection);
                if (!response) {
                    System.Console.WriteLine("That's not a number!");
                    attempts += 1;
                }
                else {
                    firstList.Add(selection);
                    counter += 1;
                }
            }
            if (attempts < 3)
                attempts = 0;

            while (attempts < 3) {
                if (attempts == 0)
                    System.Console.WriteLine("Now enter another number to see if it's in the array.");
                else
                    System.Console.WriteLine("Enter a new number to see if it's in the array.");
                response = int.TryParse(Console.ReadLine(), out selection);
                if (!response) {
                    System.Console.WriteLine("That's not a number!");
                    attempts += 1;
                }
                else {
                    break;
                }
            }

            int exists = 0;
            if (attempts < 3) {
                foreach(int number in firstList) {
                    if (number == selection) {
                        exists += 1;
                    }
                }
            }

            if (exists > 0) {
                System.Console.WriteLine($"The number '{selection}' is in the array.");
            }
            else {
                System.Console.WriteLine($"The number '{selection}' is not in the array.");
            }
        }
    }
}
