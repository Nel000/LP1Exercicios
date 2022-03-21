using System;

namespace Ex40._41._42
{
    class Program
    {
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

            Moves p1Move = (Moves) player1, p2Move = (Moves) player2;

            if (player1 == player2)
            {
                score = (int) Results.Draw; // Draw
            }
            if (((p1Move == Moves.Rock) && (p2Move == Moves.Scissors)) ||
                ((p1Move == Moves.Scissors) && (p2Move == Moves.Paper)) ||
                ((p1Move == Moves.Paper) && (p2Move == Moves.Rock)))
            {
                score = (int) Results.P1Win; // Player 1 wins
            }
            else
            {
                score = (int) Results.P2Win; // Player 2 wins
            }

            return score;
        }
    }
}
