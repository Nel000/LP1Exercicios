using System;

namespace Ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables to store user input
            int n1, n2, n3;

            // Requests input from user and stores it in variables
            Console.Write("Primeiro número - ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo número  - ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Terceiro número - ");
            n3 = Convert.ToInt32(Console.ReadLine());

            // Determine if 2 of the numbers can be added to obtain the other
            if (n1 + n2 == n3 || n1 + n3 == n2 || n2 + n3 == n1)
                Console.WriteLine("É possível :)");
            else
                Console.WriteLine("Impossível :(");
        }
    }
}
