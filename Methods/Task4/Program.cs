using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter a string: ");
            string response = Console.ReadLine();
            Spaces(response);
        }
        public static void Spaces(string response) {
            response = response.Trim();
            string[] bySpaces = response.Split(' ');
            System.Console.WriteLine($"\"{response}\" contains {bySpaces.Length - 1} spaces.");
        }
    }
}
