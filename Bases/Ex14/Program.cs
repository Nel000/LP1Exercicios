using System;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables to store user input
            string ls, ws, hs;
            double l, w, h;

            // Introductory message
            Console.WriteLine("Length, width and height for a parallelepiped:");

            // Store user input in strings
            ls = Console.ReadLine();
            ws = Console.ReadLine();
            hs = Console.ReadLine();

            // Convert strings to double
            l = Convert.ToDouble(ls);
            w = Convert.ToDouble(ws);
            h = Convert.ToDouble(hs);

            // Print volume of triangle based on user input
            Console.WriteLine("Volume of parallelepiped: {0}",
                l * w * h);
        }
    }
}
