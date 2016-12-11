using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Connect4
{
    class Ellipse
    {
        public int PenWidth;
        public Color Color;
        public Rectangle Rectangle;

        // Paint ourselves with the specified Graphics object
        public void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(Color, PenWidth))
                graphics.DrawEllipse(pen, Rectangle);
        }
    }
}
