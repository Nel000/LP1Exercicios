using System;

namespace Ex43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Terrains:");
            Console.WriteLine($"-{Grazer.Eat(Terrain.Rock)}");
            Console.WriteLine($"-{Grazer.Eat(Terrain.Plains)}");
            Console.WriteLine($"-{Grazer.Eat(Terrain.Forest)}");
            Console.WriteLine($"-{Grazer.Eat(Terrain.Jungle)}");

            Console.WriteLine();

            Console.WriteLine("Other terrains:");
            Console.WriteLine($"-{Grazer.Eat(BonusTerrain.Water)}");
            Console.WriteLine($"-{Grazer.Eat(BonusTerrain.Food)}");
        }
    }
}
