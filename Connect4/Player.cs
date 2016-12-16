using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    class Player
    {
        public string name;
        public int id;
        public int score;
        public Player(string name, int id)
        {
            this.id = id;
            this.name = name;
            this.score = 0;
        }
    }
}
