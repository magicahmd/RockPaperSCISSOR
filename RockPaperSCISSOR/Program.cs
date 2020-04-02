using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSCISSOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Ahmad");
            Player player2 = new Player("Walid");
            Game game = new Game(100, player1, player2);

            game.playGame();

            Player winner = game.getWinnerPlayer();
            Player loser = game.getLoserPlayer();

            if (winner != null && loser != null)
            {
                Console.WriteLine("\nWinner is: " + winner.name + " - score: " + winner.score);
                Console.WriteLine("Loser is: " + loser.name + " - score: " + loser.score);
                Console.WriteLine("Ties: " + (game.iterations - winner.score - loser.score));
            }
            else
            {
                Console.WriteLine("\n" + player1.name + " - score: " + player1.score);
                Console.WriteLine(player2.name + " - score: " + player2.score);
                Console.WriteLine("TIE!");
            }

            Console.ReadKey();
        }
    }
}
