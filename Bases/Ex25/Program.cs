using System;

namespace Ex25
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxTurns = 20;
            int turn = 0;

            while (turn < maxTurns)
            {
                turn++;

                if (turn % 3 != 0)
                {
                    Console.WriteLine($"Turn number {turn}");
                }
            }

            Console.WriteLine($"Last turn was {turn}");
        }
    }
}
