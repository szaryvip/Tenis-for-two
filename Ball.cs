using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tenis_for_two
{
    class Ball
    {
        public int x;
        public int y;
        public int v = 10;
        public string move = "right";
        public string move_vertical = "down";
        public int size;
        public Ball(int width,int height)
        {
            size = width / 30;
            x = width / 2 - size/2;
            y = height / 2 - size / 2-200;
        }
        public void draw(Graphics g, Brush b)
        {
            g.FillRectangle(b, x, y, size, size);
        }
        public void HitV()//change vertical move
        {
            if (move_vertical == "down") { move_vertical = "up"; }
            if (move_vertical == "up") { move_vertical = "down"; }
        }
        public void Hit()//change move from right to left and reversed
        {
            if (move == "right") { move = "left"; }
            if (move == "left") { move = "right"; }
        }
        
        public void Move()
        {
            if(move=="right" && move_vertical=="down")
            {
                x += v;
                y += v;
            }
            if (move == "right" && move_vertical == "up")
            {
                x += v;
                y -= v;
            }
            if (move == "left" && move_vertical == "down")
            {
                x -= v;
                y += v;
            }
            if (move == "left" && move_vertical == "up")
            {
                x -= v;
                y -= v;
            }
        }
    }
}
