using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {

            stopchek = 0;

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (stopchek==0)
            {
                y1 -= 10;

                y3 -= 10;

                y4 -= 10;

                Invalidate();
            }
            
        }

        Pen pen_Black = new Pen(Color.Black, 2);

        int x1, x2, y1, y2, x3, y3, x4, y4;

        int stopchek = 0;

        private void StopBtn_click(object sender, EventArgs e)
        {
            stopchek = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = ClientSize.Width / 2;

            x3 = x1 + 50;

            x4 = x1 + 100;

            y1 = ClientSize.Height / 2 + 100;

            y3 = y1 - 100;

            y4 = y1;

            x2 = 100;

            y2 = 200;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle rectangle_Rocket = new Rectangle(x1, y1, x2, y2);

            g.DrawLine(pen_Black, x1, y1, x3, y3);

            g.DrawLine(pen_Black, x3, y3, x4, y4);

            e.Graphics.DrawRectangle(pen_Black, rectangle_Rocket);
        }
    }
}
