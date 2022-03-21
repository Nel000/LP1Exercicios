using System;

namespace Ex40._41._42
{
    class Program
    {
        const int ROCK = 1;
        const int PAPER = 2;
        const int SCISSORS = 3;

        static void Main(string[] args)
        {
            int p1, p2, result;

            Console.WriteLine("Options: Rock (1) - Paper (2) - Scissors (3)");

            Console.Write("Player 1, place your option: ");
            p1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Player 2, place your option: ");
            p2 = Convert.ToInt32(Console.ReadLine());

            result = RockPaperScissors(p1, p2);

            if (result > 0)
                Console.WriteLine($"Player {result} wins!");
            else
                Console.WriteLine("It's a draw!");
        }

        /// <summary>
        /// Executes a play between 2 players according to the following rules:
        /// Rock beats Scissors; Scissors beats Paper; Paper beats Rock.
        /// </summary>
        /// <param name="player1">Number corresponding to player 1</param>
        /// <param name="player2">Number corresponding to player 2</param>
        /// <returns>
        /// The number of the winning player, or 0 in case of a draw
        /// </returns>
        static int RockPaperScissors(int player1, int player2)
        {
            int score;

            if (player1 == player2)
            {
                score = 0; // Draw
            }
            if (((player1 == ROCK) && (player2 == SCISSORS)) ||
                ((player1 == SCISSORS) && (player2 == PAPER)) ||
                ((player1 == PAPER) && (player2 == ROCK)))
            {
                score = 1; // Player 1 wins
            }
            else
            {
                score = 2; // Player 2 wins
            }

            return score;
        }
    }
}
