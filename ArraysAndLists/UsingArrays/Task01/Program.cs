using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that reads in 5 names from the console.  It then prints out "Hello <name>" for all the names entered
            int limit = 5;
            string[] names = new string[limit];

            int counter = 0;
            while (counter < limit) {
                Console.Write($"Enter name {counter + 1}: ");
                names[counter] = Console.ReadLine();
                counter += 1;
            }

            foreach(string name in names) {
                System.Console.WriteLine($"Hello, {name}!");
            }
        }
    }
}
