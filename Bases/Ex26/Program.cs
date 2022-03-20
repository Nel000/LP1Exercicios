using System;

namespace Ex26
{
    class Program
    {
        static void Main(string[] args)
        {
            // Turns
            int maxTurns = Convert.ToInt32(args[0]) - 1, currentTurn = 0;

            // Alive?
            bool alive = true;

            // Criar objeto do tipo Random
            Random rng = new Random();

            // Game Loop
            do
            {
                // Obter double entre 0 e 1
                double probability = rng.NextDouble();

                currentTurn++;
                
                if (probability <= 0.02)
                {
                    Console.WriteLine(
                        $"Player has died after {currentTurn} turns");
                    alive = false;
                }
                else
                {
                    Console.WriteLine(
                        $"Player has survived turn {currentTurn}");
                }
            }
            while (currentTurn <= maxTurns && alive);
        }
    }
}
