using System;

namespace Ex25
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            Character npc = new NPC();
            Character player = new Player();

            do
            {
                char npcDirection = npc.Move();
                char playerDirection = player.Move();

                Console.WriteLine();

                Console.WriteLine($"NPC direction: {npcDirection}");
                Console.WriteLine($"Player direction: {playerDirection}");
            }
            while(running);
        }
    }
}
