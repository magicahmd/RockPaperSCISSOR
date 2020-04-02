using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSCISSOR
{
    public class Game
    {
        public int iterations;
        public Player player1;
        public Player player2;
        static bool?[,] chances =
        {
            {null, false, true},
            {true, null, false},
            {false, true, null}
        };
        public Game(int iterations, Player player1, Player player2)
        {
            this.iterations = iterations;
            this.player1 = player1;
            this.player2 = player2;
        }
        public static bool? checkRoundWinner(int player1Turn, int player2Turn)
        {
            return (chances[player1Turn, player2Turn]);
        }

        public void playGame()
        {
            player1.score = 0;
            player2.score = 0;

            for (int i = 0; i < iterations; i++)
            {
                player1.randomTurn();
                player2.setTurn(TurnType.PAPER);
                playRound();
                printRound();
            }
        }
        public void playRound()
        {
            switch (checkRoundWinner((int)player1.turn, (int)player2.turn))
            {
                case true:
                    player1.score++;
                    break;
                case false:
                    player2.score++;
                    break;
                default:
                    break;
            }
        }
        public void printRound()
        {
            char roundResult;
            switch (checkRoundWinner((int)player1.turn, (int)player2.turn))
            {
                case true:
                    roundResult = '>';
                    break;
                case false:
                    roundResult = '<';
                    break;
                default:
                    roundResult = '=';
                    break;
            }
            Console.WriteLine((TurnType)player1.turn + " " + roundResult + " " + (TurnType)player2.turn);
        }
        public Player getWinnerPlayer()
        {
            if (player1.score == player2.score)
                return null;
            return (player1.score > player2.score ? player1 : player2);
        }
        public Player getLoserPlayer()
        {
            if (player1.score == player2.score)
                return null;
            return (player1.score < player2.score ? player1 : player2);
        }
    }
}
