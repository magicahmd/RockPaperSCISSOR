using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSCISSOR
{
    class Game
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
        public bool? checkRoundWinner()
        {
            return (chances[(int)player1.turn, (int)player2.turn]);
        }
        public void playRound()
        {
            switch (checkRoundWinner())
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
            switch (checkRoundWinner())
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
    }
}
