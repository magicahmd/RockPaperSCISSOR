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
        public Game(int iterations, Player player1, Player player2)
        {
            this.iterations = iterations;
            this.player1 = player1;
            this.player2 = player2;
        }
    }
}
