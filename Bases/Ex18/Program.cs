using System;

namespace Ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stores user input as string
            string s;

            // Request user input
            Console.WriteLine("Please write a sentence");

            // Get user input
            s = Console.ReadLine();

            // Print user input
            Console.WriteLine($"String = {s}");
        }
    }
}
