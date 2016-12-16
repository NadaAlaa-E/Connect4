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
        public Disc[][] cells;
        public Board() { }
        public int[] sizeOfCol;

        public Board(int num_rows, int num_columns)
        {
            this.num_rows = num_rows;
            this.num_columns = num_columns;
            this.cells = new Disc[num_columns][];
            this.sizeOfCol = new int[num_columns];
            for (int i = 0; i < num_columns; i++)
            {
                cells[i] = new Disc[num_rows];
                sizeOfCol[i] = 0;
            }
        }
        public bool AddDisc(Disc disc)
        {
            if (sizeOfCol[disc.column] >= num_rows) return false;

            disc.row = sizeOfCol[disc.column];
            cells[disc.column][sizeOfCol[disc.column]++] = disc;
            return true;
        }
        public bool RemoveDisc(int col)
        {
            if (sizeOfCol[col] <= 0) return false;

            cells[col][--sizeOfCol[col]] = null;
            return true;
        }
        public bool IsValid(int row, int col)
        {
            return row >= 0 && col >= 0 && row < num_rows && col < num_columns;
        }
    }
}
