using System;

namespace Ex41
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
