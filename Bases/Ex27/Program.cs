using System;

namespace Ex27
{
    class Program
    {
        static void Main(string[] args)
        {
            // Number of rows and spaces at any given time
            int rows, space;

            // Get number of rows from user input
            rows = Convert.ToInt32(Console.ReadLine());

            // Number of spaces is equal to number of rows, initially
            space = rows;

            if (rows > 9)
            {
                // Display error message and end program
                Console.WriteLine("ERROR");
            }
            else
            {
                // Top half of diamond
                for (int i = 1; i <= rows; i++)
                {
                    // Draw spaces
                    for (int j = space; j >= 1; j--)
                        Console.Write(" ");
                    // Draw numbers
                    for (int k = 1; k <= 2 * i - 1; k++)
                        Console.Write($"{i}");

                    // Move onto new line
                    Console.Write("\n");
                    space--;
                }
                // Bottom half of diamond
                for (int i = rows - 1; i >= 1; i--)
                {
                    // Draw spaces
                    for (int j = space + 2; j >= 1; j--)
                        Console.Write(" ");
                    // Draw numbers
                    for (int k = 1; k <= 2 * i - 1; k++)
                        Console.Write($"{i}");

                    // Move onto new line
                    Console.Write("\n");
                    space++;
                }
            }
        }
    }
}
