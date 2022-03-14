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

            // 21)
            double x = 0.1592;
            double y = 1.1231;

            Console.WriteLine($"x igual a {x,6:p1}");
            Console.WriteLine($"y igual a {y,6:p1}");
            // x igual a  15.9%
            // y igual a 112.3%
            // p formats double as percentage

            // 22)
            int a = 10;
            int b = 100;
            int c = 1000;

            string s1 = String.Format("{0,4}", a);
            string s2 = String.Format("{0,4}", b);
            string s3 = String.Format("{0,4}", c);

            Console.WriteLine(s1 + "\n" + s2 + "\n" + s3);
            //   10
            //  100
            // 1000
            // \n produces a new line
        }
    }
}
