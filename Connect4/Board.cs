using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Connect4
{
    class Board
    {
        public int num_columns, num_rows;
        public List<Disc>[] cells;
        public Board() { }
        public Board(int num_rows, int num_columns)
        {
            this.num_rows = num_rows;
            this.num_columns = num_columns;
            this.cells = new List<Disc>[num_columns];
            for (int i = 0; i < num_columns; i++) cells[i] = new List<Disc>(num_rows);
        }
        public bool AddDisc(Disc disc)
        {
            if (cells[disc.column].Count >= num_rows) return false;

            disc.row = cells[disc.column].Count;
            cells[disc.column].Add(disc);
            Game.turn = (Game.turn + 1) % 2;
            return true;
        }
    }
}
