using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            user(name);
        }
        public static void user(string name)
            {
                System.Console.WriteLine($"Welcome friend {name}!");
                System.Console.WriteLine("Have a nice day!");
            }
    }
}
