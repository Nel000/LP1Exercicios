using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            // The string to be filled by the user
            string userString;

            // Introductory message
            Console.WriteLine("Please write a string");
            // Read user input and save onto string
            userString = Console.ReadLine();
            
            // Print back user input as string
            Console.WriteLine($"User entered string: {userString}");
        }
    }
}
