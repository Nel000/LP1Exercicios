using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            // The user string
            string userString;

            // Writes an introductory message
            Console.WriteLine("Please write something");

            // Saves user input as string
            userString = Console.ReadLine();

            // FOR loop goes from last to first character of user string
            for (int i = userString.Length - 1; i >= 0; i--)
                // Prints each letter from the string from last to first
                Console.Write(userString[i]);
        }
    }
}
