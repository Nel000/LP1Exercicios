using System;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables to be defined by the user
            string i , j;
            int ii, ij;

            // Introductory message
            Console.WriteLine("Write 2 integers:");
            
            // Store user input in string
            i = Console.ReadLine();
            j = Console.ReadLine();

            // Convert strings to int
            ii = Convert.ToInt32(i);
            ij = Convert.ToInt32(j);

            // Print sum of 2 ints
            Console.WriteLine($"Sum between {ii} and {ij} is {ii + ij}");
        }
    }
}
