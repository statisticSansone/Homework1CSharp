using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyHomework1
{
    public partial class Lavagna : Form
    {
        public Lavagna()
        {
            InitializeComponent();
            panel1.Invalidate();
        }

        private void Lavagna_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = e.Graphics;
            Pen pen = new Pen(Color.Yellow, 3);

            //Draw a point
            e.Graphics.DrawRectangle(pen, 250, 10, 1, 1);

            //Draw a line
            pen.Color = Color.White;
            e.Graphics.DrawLine(pen, 200, 200, 200, 20);

            //Draw a rectangle
            pen.Color = Color.Blue;
            Rectangle rectangle = new Rectangle(60, 200, 100, 20);
            e.Graphics.DrawRectangle(pen, rectangle);

            //Draw a circle
            pen.Color = Color.Red;
            Rectangle rectForEllipse = new Rectangle(30, 20, 150, 150);
            e.Graphics.DrawEllipse(pen, rectForEllipse);
        }
    }
}
