using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(300, 300);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Pen pen = new Pen(Color.Black);
            //Point startPoint = new Point(45, 45);
            //Point endPoint = new Point(150, 150);

            //pen.Width = 5.0f;

            //e.Graphics.DrawLine(pen, startPoint, endPoint);
            //e.Graphics.DrawLine(pen, 150, 45, 45, 150);

            Image img = new Bitmap(Properties.Resources.Image1);
            e.Graphics.DrawImage(img, 0, 0,300,300);

        }
    }
}
