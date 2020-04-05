using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    public class Player
    {
        public string name;
        public int score = 0;
        public TurnType turn;
        Random random = new Random();

        public Player(string name)
        {
            this.name = name;
        }
        public void setTurn(TurnType turn)
        {
            this.turn = turn;
        }

        public void randomTurn()
        {
            int randomTurn = random.Next(0, 3);
            turn = (TurnType)randomTurn;
        }
    }
}
