﻿using System;
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

            for (int i = 0; i < game.iterations; i++)
            {
                player1.randomTurn();
                player2.setTurn(TurnType.PAPER);
                game.playRound();
                game.printRound();
            }

            Console.ReadKey();
        }
    }
}
