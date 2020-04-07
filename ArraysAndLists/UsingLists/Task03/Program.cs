using System;
using System.Collections.Generic;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            // A program stores words read from console, until the word "stop" is entered.  It then outputs the words entered in reverse order.
            string response = "";
            List<string> responses = new List<string>();

            System.Console.WriteLine("Enter words you would like to add. Enter 'stop' to stop.");
            while (response != "stop") {
                System.Console.Write("Add: ");
                response = Console.ReadLine();
                if (response != "stop")    
                    responses.Add(response);
            }

            responses.Reverse();
            if (responses.Count <= 10) {
                System.Console.Write("\nWords entered (in reverse order): ");
                foreach(string item in responses) {
                    System.Console.Write(item + " ");
                }
                System.Console.WriteLine();
            }
            else {
                System.Console.WriteLine("\nWords entered (in reverse order): ");
                foreach(string item in responses) {
                    System.Console.WriteLine(item);
                }
            }
        }
    }
}
