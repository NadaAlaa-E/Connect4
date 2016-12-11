using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Connect4
{
    class Disc
    {
        public int row;
        public int column;
        public int color;
        public Disc(int column, int color)
        {
            this.column = column;
            this.color = color;
        }
    }
}
