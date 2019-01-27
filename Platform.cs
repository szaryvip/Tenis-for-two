using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tenis_for_two
{
    class Platform
    {
        public int x;
        public int y;
        public int height = 80;
        public int width = 20;
        public string move="0";
        public Platform(int width, int height)
        {
            x = width;
            y = (height/2)-40;
        }
        public void Moves()
        {
            
            
                if (move == "up" && y>30)
                {
                    y = y - 30;
                }
                if (move == "down" && y<(370-height))
                {
                    y = y + 30;
                }
            
        }
        public void draw(Graphics g, Brush b)
        {
            g.FillRectangle(b, x, y, width, height);
        }
    }
}
