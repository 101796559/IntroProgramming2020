using System;

namespace SelectionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get username and password

            // If username exists 
                    // If password correct
                        // print login successful
                    // Else
                        // Print login unsuccessful
            // Else
                // print login unsuccessful

            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            string sysUsername = "bob";
            string sysPassword = "bob";

            if (username == sysUsername) {
                // Uncomment to check username first.
                // Console.Write("Password: ");
                // string password = Console.ReadLine();

                if (password == sysPassword) {
                    System.Console.WriteLine("Login Successful.");
                }
                else {
                    System.Console.WriteLine("Login Failed.");
                }
            }
            else {
                System.Console.WriteLine("Login Failed.");
            }

            
        }
    }
}
