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

            // If string has more than 20 characters, print specific message
            if (s.Length > 20)
                Console.WriteLine("Too long to read");
            // Else if string has less than 5 characters, print different message
            else if (s.Length < 5)
                Console.WriteLine("That's not very meaningful, is it?");
            // Else, print default message
            else
                Console.WriteLine("Ok, if you say so.");
        }
    }
}
