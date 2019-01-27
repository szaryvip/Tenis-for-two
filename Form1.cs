using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenis_for_two
{
    public partial class Form1 : Form
    {
        private bool game_activ = false;
        private Platform platform1;
        private Platform platform2;
        private Ball ball1;
       // private int scoreleft = 0;
       // private int scoreright = 0;
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            game_activ = false;
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game_activ = true;
            platform1 = new Platform(5, game_panel.Height);
            platform2 = new Platform(575, game_panel.Height);
            ball1 = new Ball(game_panel.Width, game_panel.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (game_activ)
            {
                game_panel.CreateGraphics().Clear(Color.Black);
                platform1.Moves(); 
                platform1.draw(game_panel.CreateGraphics(), new SolidBrush(Color.White));
                platform2.Moves();
                platform2.draw(game_panel.CreateGraphics(), new SolidBrush(Color.White));
                if(ball1.isHit(platform1.y, platform1.height, platform2.y, platform2.height))ball1.Hit();
                ball1.HitV();
                ball1.Move();
                if (ball1.x < (0-ball1.size) || ball1.x > 600) { game_activ = false; }
                ball1.draw(game_panel.CreateGraphics(), new SolidBrush(Color.White));
            }
            else
            {
                FontFamily fontFamily = new FontFamily("Arial");
                Font f = new Font(fontFamily, 15);
                Brush b = new SolidBrush(Color.Aqua);
                game_panel.CreateGraphics().DrawString("Naciśnij Start", f, b, 240, 195);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.W) { platform1.move = "up"; }
                if (e.KeyCode == Keys.S) { platform1.move = "down"; }
                if (e.KeyCode == Keys.NumPad8) { platform2.move = "up"; }
                if (e.KeyCode == Keys.NumPad2) { platform2.move = "down"; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) {platform1.move = "0"; }
            if (e.KeyCode == Keys.S) {platform1.move = "0";}
            if (e.KeyCode == Keys.NumPad8) {platform2.move = "0";}
            if (e.KeyCode == Keys.NumPad2) {platform2.move = "0";}
            
        }
    }
}
