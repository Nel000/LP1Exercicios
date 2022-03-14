using System;

namespace Exs20._21._22
{
    class Program
    {
        static void Main(string[] args)
        {
            // 20)
            double d = 0.3513;
            float f = 12.645f;

            Console.WriteLine("d -> {0,5:f2}", d);
            Console.WriteLine("f -> {0,5:f2}", f);
            // d ->  0.35
            // f -> 12.64
            // 0 corresponds to variable index; 5 is the number of spaces it 
            // occupies, in this case, 5 to the left; f indicates that 
            // variable is formatted as float; 2 indicates number of decimal
            // spaces it occupies
        }
    }
}
