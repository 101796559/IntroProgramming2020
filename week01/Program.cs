using System;
namespace week01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string firstname = Console.ReadLine();

            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();

            Console.Write("Enter your year of birth: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the current year: ");
            int currentYear = Convert.ToInt32(Console.ReadLine());

            string age = Convert.ToString(currentYear - birthYear);

            string message = "G'day, " + firstname + " " + surname + "!\nYou are " + age + " years old this year!";
            Console.WriteLine(message);
        }
    }
}