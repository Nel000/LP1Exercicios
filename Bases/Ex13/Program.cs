using System;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            string si, sj;
            double i, j;

            // Initial message
            Console.WriteLine("Insert 2 floating point numbers");

            // Store user input in strings
            si = Console.ReadLine();
            sj = Console.ReadLine();

            // Convert strings to float
            i = Convert.ToDouble(si);
            j = Convert.ToDouble(sj);

            // Print result of the operation
            Console.WriteLine($"{i} elevated to {j} equals {Math.Pow(i, j)}");
        }
    }
}
