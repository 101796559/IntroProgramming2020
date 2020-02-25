using System;

namespace week01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name?");
            string firstname = Console.ReadLine();
            
            Console.WriteLine("What's your surname?");
            string surname = Console.ReadLine();
            
            string message = "G'day, " + firstname + " " + surname + "!";

            Console.WriteLine(message);
        }
    }
}
