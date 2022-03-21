using System;

namespace Ex45
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = Convert.ToInt32(Console.ReadLine());

            int blocks = Triang(lines);

            Console.WriteLine(blocks);
        }

        static int Triang(int lines)
        {
            int blocks = 0;

            if (lines > 0)
                // Ex: 4
                // (4 - 1) + [4]; (3 - 1) + [3]; (2 - 1) + [2]; (1 - 1) + [1];
                // = 10
                blocks = Triang(lines - 1) + lines;
            else
                lines = 0;
            
            return blocks;
        }
    }
}
